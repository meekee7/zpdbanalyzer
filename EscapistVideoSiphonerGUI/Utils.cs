using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using EscapistFetch;
using EscapistVideoArchiver;

namespace EscapistVideoSiphonerGUI
{
    public static class URLLoader
    {
        public static List<string> loadURLsFromFile(string filename)
        {
            return new List<string>(filename.EndsWith(".txt") ? File.ReadLines(filename) : VideoIO.readFile(filename).videos.Select(x => x.escurl));
        }
    }

    public static class Siphoner
    {
        public static async Task siphon(List<String> urls, int start, int end,
            Action<ulong, ulong> dlupdatehandler, Action<string, bool> dlfinishhandler, Action cancelaction, CancellationToken ctoken,
            PauseToken ptoken, ParsingRequest.RESOLUTION resolution, ParsingRequest.CONTAINER container, string targetdir,
            Action htmlaction, Action jsonaction, Action<int, int, int> generalprogress
            )
        {
            var failures = new List<string>();
            for (int i = start; i < end; i++)
            {
                if (new DriveInfo("" + targetdir[0]).TotalFreeSpace < 20_000_000_000)
                {
                    MessageBox.Show("Error: Less than 20GB of free space available. Cancelling siphoning.");
                    break;
                }

                await ptoken.WaitWhilePausedWithResponseAsyc();

                var semaphore = new Semaphore(0, 1);

                await Grabber.evaluateURL(new ParsingRequest(urls[i], resolution, container),
                    async exception => failures.Add(urls[i]),
                    htmlaction,
                jsonaction,
                async (s, container1) => targetdir + "\\" + s + (container1 == ParsingRequest.CONTAINER.C_MP4 ? ".mp4" : ".webm"),
                    new SiphonDownloadHelper(dlupdatehandler, (s, b) =>
                    {
                        dlfinishhandler.Invoke(s, b);
                        semaphore.Release();
                    }),
                async s => MessageBox.Show(s),
                () => failures.Add(urls[i]),
                ctoken
                );

                semaphore.WaitOne();

                try
                {
                    await Task.Delay(5000, ctoken);
                }
                catch (TaskCanceledException)
                {
                    break; //Exit the loop
                }

                if (ctoken.IsCancellationRequested)
                {
                    break;
                }
            }

            using (var sw = File.CreateText("MISSED-URLS-" + System.DateTime.UtcNow + ".txt"))
                failures.ForEach(x => sw.WriteLine(x));
        }
    }

    public class SiphonDownloadHelper : Downloader
    {
        private WebClient download;

        public SiphonDownloadHelper(Action<ulong, ulong> updatehandler, Action<string, bool> finishhandler) : base(updatehandler, finishhandler)
        {
        }

        public override void finishdl()
        {
            if (download != null)
            {
                download.CancelAsync();
                download = null;
            }
        }

        public void pausedl()
        {
            //TODO
        }

        public override void startdownload(string sourceuri, string targeturi)
        {
            download = new WebClient();
            download.DownloadProgressChanged +=
                (sender, e) => updatehandler.Invoke((ulong)e.BytesReceived, (ulong)e.TotalBytesToReceive);
            download.DownloadFileCompleted += (sender, e) => finishhandler.Invoke(targeturi, e.Cancelled);
            download.DownloadFileAsync(new Uri(sourceuri), targeturi);
        }
    }



    //Borrowed from https://github.com/johanneszab/TumblThree/blob/master/src/TumblThree/TumblThree.Applications/PauseTokenSource.cs
    public class PauseTokenSource
    {
        internal static readonly TaskCompletionSource<bool> s_completedTcs;
        private readonly object m_lockObject = new object();
        bool m_paused = false; // could use m_resumeRequest as flag too
        private TaskCompletionSource<bool> m_pauseResponse;
        private TaskCompletionSource<bool> m_resumeRequest;

        static PauseTokenSource()
        {
            s_completedTcs = new TaskCompletionSource<bool>();
            s_completedTcs.SetResult(true);
        }

        public bool IsPaused
        {
            get
            {
                lock (m_lockObject)
                    return m_paused;
            }
        }

        public PauseToken Token => new PauseToken(this);

        public void Pause()
        {
            lock (m_lockObject)
            {
                if (m_paused)
                {
                    return;
                }
                m_paused = true;
                m_pauseResponse = s_completedTcs;
                m_resumeRequest = new TaskCompletionSource<bool>();
            }
        }

        public void Resume()
        {
            TaskCompletionSource<bool> resumeRequest = null;

            lock (m_lockObject)
            {
                if (!m_paused)
                {
                    return;
                }
                m_paused = false;
                resumeRequest = m_resumeRequest;
                m_resumeRequest = null;
            }

            resumeRequest.TrySetResult(true);
        }

        // pause with a feedback that
        // the producer task has reached the paused state

        public Task PauseWithResponseAsync()
        {
            Task responseTask = null;

            lock (m_lockObject)
            {
                if (m_paused)
                {
                    return m_pauseResponse.Task;
                }
                m_paused = true;
                m_pauseResponse = new TaskCompletionSource<bool>();
                m_resumeRequest = new TaskCompletionSource<bool>();
                responseTask = m_pauseResponse.Task;
            }

            return responseTask;
        }

        public Task WaitWhilePausedWithResponseAsyc()
        {
            Task resumeTask = null;
            TaskCompletionSource<bool> response = null;

            lock (m_lockObject)
            {
                if (!m_paused)
                {
                    return s_completedTcs.Task;
                }
                response = m_pauseResponse;
                resumeTask = m_resumeRequest.Task;
            }

            response.TrySetResult(true);
            return resumeTask;
        }
    }

    public struct PauseToken
    {
        private readonly PauseTokenSource m_source;

        public PauseToken(PauseTokenSource source)
        {
            m_source = source;
        }

        public bool IsPaused => m_source != null && m_source.IsPaused;

        public Task WaitWhilePausedWithResponseAsyc()
        {
            return IsPaused
                ? m_source.WaitWhilePausedWithResponseAsyc()
                : PauseTokenSource.s_completedTcs.Task;
        }
    }
}
