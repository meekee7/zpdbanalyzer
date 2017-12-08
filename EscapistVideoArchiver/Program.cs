using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EscapistFetch;

namespace EscapistVideoArchiver
{
    class Program
    {
        static async Task fetchMissing()
        {
            var videolist = new List<Video>(1000);
            var brokenurls = new List<string>();

            var urlstoparse = new List<string>(File.ReadLines("BrokenURLs-1.txt"));

            for (int i = 0; i < urlstoparse.Count; i++)
            {
                string url = urlstoparse[i];
                Console.WriteLine(url);
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
                Console.WriteLine("Parsed video " + i + " (" + (i * 100 / urlstoparse.Count) + "%)");
                Thread.Sleep(5000);
            }


            VideoIO.writeFile("VideoDB-Missing-2.xml", new VideoList
            {
                videos = videolist.ToArray()
            });

            using (var sw = File.CreateText("BrokenURLs-2.txt"))
                brokenurls.ForEach(x => sw.WriteLine(x));
        }

        static async Task fetchVideoData(uint start, uint end)
        {
            if (start > end)
                throw new ArgumentException("start > end");
            /*
            if (end - start > 1000)
                throw new ArgumentException("Range too large (> 1000)");
                */
            urlset urlset = SitemapIO.readFile("sitemap_video_0.xml");

            if (end >= urlset.url.Length)
            {
                Console.WriteLine("WARNING UPPER BOUNDARY TOO HIGH");
                end = (uint)urlset.url.Length - 1;
                Console.WriteLine("Setting upper boundary to " + end);
            }

            var knownvideos = VideoIO.readFile("VideodatabaseFull.xml");

            var videolist = new List<Video>((int)(end - start));
            var brokenurls = new List<string>();

            int i = 10000;
            foreach (var url in urlset.url)
                //for (uint i = start; i < end; i++)
                if (knownvideos.videos.All(x => x.escurl != url.loc))
                {
                    //  string url = urlset.url[i].loc;
                    try
                    {
                        var video = await Utils.fetchVideoData(url.loc);
                        video.number = (int)i++;
                        videolist.Add(video);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        brokenurls.Add(url.loc);
                    }
                    //Console.WriteLine("Parsed video " + i + " (" + (i * 100 / (end - start)) + "%)");
                    Console.WriteLine(url.loc);
                    Thread.Sleep(5000);
                }


            VideoIO.writeFile("VideoDB-" + start + "-" + end + ".xml", new VideoList
            {
                videos = videolist.ToArray()
            });

            using (StreamWriter sw = File.CreateText("BrokenURLs-" + start + "-" + end + ".txt"))
                brokenurls.ForEach(x => sw.WriteLine(x));
        }

        static void sortList()
        {
            var knownvideos = VideoIO.readFile("VideodatabaseFull.xml");
            var videolist = knownvideos.videos;
            Array.Sort(videolist, (video, video1) => video.date.CompareTo(video1.date));
            for (int i = 0; i < videolist.Length; i++)
                videolist[i].number = i + 1;

            VideoIO.writeFile("VideodatabaseFullSorted.xml", new VideoList
            {
                videos = videolist.ToArray()
            });
        }

        static void shiftnumbers()
        {
            urlset urlset = SitemapIO.readFile("sitemap_video_0.xml");
            var knownvideos = VideoIO.readFile("VideodatabaseFullSorted.xml");
            var videolist = knownvideos.videos;
            var missing = new List<string>(File.ReadAllLines("BrokenURLs-1.txt"));
            foreach (var tUrl in urlset.url.Where(x => missing.Contains(x.loc)))
            {
                var date = DateTime.Parse(tUrl.lastmod);
                foreach (var video in videolist.Where(x => x.date > date))
                    video.number++;
            }


            VideoIO.writeFile("VideodatabaseFullSorted.xml", new VideoList
            {
                videos = videolist.ToArray()
            });
        }

        static async Task siphonVideos(int startid, int endid, ParsingRequest.CONTAINER c, ParsingRequest.RESOLUTION r)
        {
            if (startid > endid)
                throw new ArgumentException("start > end");

            if (endid - startid > 500)
                throw new ArgumentException("Range too large (> 500)");

            if (!File.Exists("VideodatabaseFull.xml"))
                throw new ArgumentException("Video database file VideodatabaseFull.xml not found");

            string targetdir = "" + (c == ParsingRequest.CONTAINER.C_MP4 ? "MP4" : "WEBM") + (r == ParsingRequest.RESOLUTION.R_360P ? "360" : "480");
            if (!Directory.Exists(".\\" + targetdir))
                Directory.CreateDirectory(".\\" + targetdir);



            var list = VideoIO.readFile("VideodatabaseFull.xml").videos;

            var failures = new List<string>();

            for (var i = startid; i <= endid; i++)
            {
                var video = list.FirstOrDefault(x => x.number == i);
                if (video != null)
                {
                    Console.WriteLine("Loading " + video.escurl + " ... ");
                    Console.Write("000%");
                    Semaphore semaphore = new Semaphore(0, 1);
                    try
                    {
                        await Grabber.evaluateURL(
                            new ParsingRequest(video.escurl, r, c),
                            async exception => throw exception,
                            () => { },
                            () => { },
                            async (s, container) =>
                               (".\\" + targetdir + "\\" + i + " " + s + "." +
                                (container == ParsingRequest.CONTAINER.C_MP4 ? "mp4" : "webm")
                            ),
                            new Downloadhelper(((arg1, arg2) =>
                                {
                                    Console.Write("\b\b\b\b{0:D3}%", arg1 * 100 / arg2);
                                }),
                            ((s, b) => semaphore.Release())),
                            async (s) => Console.WriteLine(s),
                            (() => { }),
                            new CancellationToken(false)
                        );
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        semaphore.Release();
                        failures.Add(i + " " + video.escurl);
                    }
                    semaphore.WaitOne();
                    await Task.Delay(4000);
                    Console.WriteLine(" End " + video.escurl);
                }
                else
                    failures.Add(i.ToString());
            }


            using (StreamWriter sw = File.CreateText("Failures-" + startid + "-" + endid + ".txt"))
                failures.ForEach(x => sw.WriteLine(x));
        }

        static void Main(string[] args)
        {
            /*
            if (args.Length < 2)
            {
                Console.WriteLine("USAGE: .\\EscapistVideoArchiver.exe [LowerBoundaryInclusive] [UpperBoundaryExclusive]");
                Console.WriteLine("EXAMPLE: .\\EscapistVideoArchiver.exe 0 1000");
                Console.WriteLine("This build will only archive the video metadata.");
            }
            else
            {
                fetchVideoData(Convert.ToUInt32(args[0]), Convert.ToUInt32(args[1])).Wait();
            }
            */
            //shiftnumbers();
            //sortList();
            //fetchVideoData(0, 10000).Wait();
            //fetchMissing().Wait();
            int? start = null;
            int? end = null;
            ParsingRequest.CONTAINER? c = null;
            ParsingRequest.RESOLUTION? r = null;

            for (int i = 0; i < args.Length - 1; i++)
                if (args[i] == "-start")
                    start = Int32.Parse(args[i + 1]);
                else if (args[i] == "-end")
                    end = Int32.Parse(args[i + 1]);
                else if (args[i] == "-cont")
                {
                    var cs = args[i + 1].ToLower();
                    if (cs == "mp4")
                        c = ParsingRequest.CONTAINER.C_MP4;
                    else if (cs == "webm")
                        c = ParsingRequest.CONTAINER.C_WEBM;
                }
                else if (args[i] == "-res")
                {
                    var rs = args[i + 1].ToLower();
                    if (rs == "360" || rs == "360p")
                        r = ParsingRequest.RESOLUTION.R_360P;
                    else if (rs == "480" || rs == "480p")
                        r = ParsingRequest.RESOLUTION.R_480P;
                }

            if (start == null)
            {
                Console.WriteLine("Error: no start value specified. Use argument -start val");
                return;
            }
            if (end == null)
            {
                Console.WriteLine("Error: no end value specified. Use argument -start val");
                return;
            }
            if (r == null)
            {
                Console.WriteLine("Error: no resolution specified. Use argument -res 480 or -res 360");
                return;
            }
            if (c == null)
            {
                Console.WriteLine("Error: no container specified. Use argument -cont mp4 or -cont webm");
                return;
            }
            siphonVideos(start.Value, end.Value, c.Value, r.Value).Wait();


            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
