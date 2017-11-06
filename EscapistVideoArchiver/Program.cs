using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using NLog.Config;

namespace EscapistVideoArchiver
{
    class Program
    {
        static async Task fetchVideoData(uint start, uint end)
        {
            if (start > end)
                throw new ArgumentException("start > end");

            if (end - start > 1000)
                throw new ArgumentException("Range too large (> 1000)");

            urlset urlset = SitemapIO.readFile("sitemap_video_0.xml");

            if (end >= urlset.url.Length)
            {
                Console.WriteLine("WARNING UPPER BOUNDARY TOO HIGH");
                end = (uint)urlset.url.Length - 1;
                Console.WriteLine("Setting upper boundary to " + end);

            }


            var videolist = new List<Video>((int)(end - start));
            var brokenurls = new List<string>();

            for (uint i = start; i < end; i++)
            {
                string url = urlset.url[i].loc;
                try
                {
                    var video = await Utils.fetchVideoData(url);
                    video.number = (int)i;
                    videolist.Add(video);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    brokenurls.Add(url);
                }
                Console.WriteLine("Parsed video " + i + " (" + (i * 100 / (end - start)) + "%)");
                Thread.Sleep(5000);
            }


            VideoIO.writeFile("VideoDB-" + start + "-" + end + ".xml", new VideoList
            {
                videos = videolist.ToArray()
            });

            using (StreamWriter sw = File.CreateText("BrokenURLs-" + start + "-"  + end  + ".txt"))
                brokenurls.ForEach(x => sw.WriteLine(x));
        }

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("USAGE: EscapistVideoArchiver.exe [LowerBoundaryInclusive] [UpperBoundaryExclusive]");
                Console.WriteLine("EXAMPLE: EscapistVideoArchiver.exe 0 1000");
                Console.WriteLine("This build will only archive the video metadata.");
            }
            else
            {
                fetchVideoData(Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1])).Wait();
            }

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
