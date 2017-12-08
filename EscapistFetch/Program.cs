using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;
using ZPDBProject;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ZPDBAnalyzer;
using ZPDBProject.YTTranscript;
using IO = ZPDBProject.IO;

namespace EscapistFetch
{
    public class Program
    {
        private static string decodeJSONConfig(string hash, string jsontext)
        {
            var t = "";
            var a = "";
            var r = "";
            while (t.Length < jsontext.Length / 2)
                t += hash;
            t = t.Substring(0, jsontext.Length / 2);
            for (var o = 0; o < jsontext.Length; o += 2)
                a += (char)Convert.ToInt32("" + jsontext[o] + jsontext[o + 1], 16);
            for (var o = 0; o < t.Length; o++)
                r += (char)(t[o] ^ a[o]);
            return r;
        }

        public static async Task addLatestEpisode()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            Episode latest = await fetchEpisode("http://www.escapistmagazine.com/videos/view/zero-punctuation/latest");
            latest.originalname = latest.name;
            if (episodes.episodes.FirstOrDefault(x => x.originalname == latest.originalname) != null)
            {
                Console.WriteLine("ERROR: Episode already in database");
                return;
            }

            addGameNames(latest);
            var sb = new StringBuilder();
            await addWikipediaNames(latest, sb);
            Console.WriteLine(sb);
            var list = episodes.episodes.ToList();
            latest.number = list.FindLast(x => true).number + 1;
            list.Add(latest);
            episodes.episodes = list.ToArray();

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        private static async Task<string> getJSONData(string jsonurl, string hash)
        {
            try
            {
                WebRequest request = WebRequest.CreateHttp(jsonurl);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = await request.GetResponseAsync();
                string jsontext = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return decodeJSONConfig(hash, jsontext);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error requesting " + jsonurl + " : " + e);
            }
            return null;
        }

        private static string ScrubHtml(string value)
        //Borrowed from Stackoverflow http://stackoverflow.com/questions/19523913/remove-html-tags-from-string-including-nbsp-in-c-sharp
        {
            string step1 = Regex.Replace(value, @"<[^>]+>|&nbsp;", "").Trim();
            string step2 = Regex.Replace(step1, @"\s{2,}", " ");
            return WebUtility.HtmlDecode(step2);
        }


        public static async Task<Episode> fetchEpisode(string url)
        {
            Episode result = new Episode();
            result.esclink = url;
            WebRequest request = WebRequest.CreateHttp(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = await request.GetResponseAsync();

            var htmldoc = new HtmlDocument();
            htmldoc.Load(response.GetResponseStream());
            HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
            HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");

            result.name = ScrubHtml(
                head?.ChildNodes.Where(node => node.Name.Equals("meta"))
                    .FirstOrDefault(
                        node => node.Attributes["name"] != null && node.Attributes["name"].Value.Equals("title"))?
                        .Attributes["content"].Value
                        .Replace("Zero Punctuation :", "").Trim());

            if (result.name.Contains('-'))
            {
                var split = result.name.Split(new[] { '-' }, StringSplitOptions.None);
                result.name = split[0].Trim();
                result.subtitle = split[1].Trim();
            }

            result.esclink = //input url could be latest-url, fetch from doc
                head?.Descendants()
                    .First(x => x.Name == "meta" && x.Attributes["property"]?.Value == "og:url")
                    .Attributes["content"].Value;

            string teaser = body?.Descendants()
                .First(x => x.Name == "span" && x.Attributes["itemprop"]?.Value == "description")?.FirstChild.InnerHtml;
            if (teaser != null)
                result.teaser = ScrubHtml(teaser);

            string datestring = body?.Descendants().Where(node => node.Name == "span")
                .First(node => node.Attributes["class"]?.Value == "publish_time").ChildNodes
                .First(node => node.Attributes["class"]?.Value == "utc_timestamp").InnerText;
            result.date = DateTime.Parse(datestring);

            var playernode = body?.Descendants()
                .Where(node => node.Name.Equals("div"))
                .Where(node => node.Attributes.Contains("id"))
                .FirstOrDefault(node => node.Attributes["id"].Value.Equals("video_player_object"));
            var codenode =
                playernode?.Descendants().FirstOrDefault(node => node.InnerText.Contains("imsVideo.play"));
            if (codenode != null)
            {
                string playerconfig =
                    codenode.InnerText.Split(new[] { "imsVideo.play(" }, StringSplitOptions.None)[1];
                playerconfig = playerconfig.Split(new[] { "});" }, StringSplitOptions.None)[0] + "}";// playerconfig.Substring(0, playerconfig.Length - 2);}
                JObject jobj = JObject.Parse(playerconfig);
                string videoID = (string)jobj["videoID"];
                string jsonhash = (string)jobj["hash"];
                string jsonurl =
                    "http://www.escapistmagazine.com/videos/vidconfig.php" + "?" + "videoID=" + videoID +
                    "&" + "hash=" + jsonhash;
                string jsontext = await getJSONData(jsonurl, jsonhash);
                JObject config = JObject.Parse(jsontext);
                result.length = (int)config["videoData"]["duration"] / 1000;
            }

            return result;
        }

        public static async Task fetchEpisodesFromFile()
        {
            List<Episode> episodes = new List<Episode>();

            StringReader urls;
            using (StreamReader sr = File.OpenText("EscapistURLsNEW.txt"))
                urls = new StringReader(sr.ReadToEnd());

            string url;
            while ((url = urls.ReadLine()) != null)
            {
                Episode episode = await fetchEpisode(url);
                Console.WriteLine("Parsed " + url);
                episodes.Add(episode);
                Thread.Sleep(2000);
            }

            EpisodeList xmllist = new EpisodeList();
            xmllist.episodes = episodes.ToArray();

            using (StreamWriter sw = File.CreateText("ZPEpisodeDBMissing.xml"))
                ZPDBProject.IO.serializer.Serialize(sw, xmllist);
        }

        public static async Task loadExp()
        {
            int range = 23;
            var sb = new StringBuilder();
            for (int i = 1; i <= range; i++)
            {
                string baseurl = "http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation." + i;
                try
                {
                    WebRequest request = WebRequest.CreateHttp(baseurl);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = await request.GetResponseAsync();

                    var htmldoc = new HtmlDocument();
                    htmldoc.Load(response.GetResponseStream());
                    //HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
                    HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");
                    var explinks = body?.Descendants()
                        .Where(x => x.Attributes["class"]?.Value == "headline")
                        .Select(x => x.ChildNodes[0].Attributes["href"].Value);

                    Console.WriteLine("Parsed page " + i);
                    Console.WriteLine(string.Join(Environment.NewLine, explinks));
                    foreach (var video in explinks)
                        sb.AppendLine(video);
                    //foreach (var video in videolinks)
                    //{
                    //    await fetchEpisode("video");
                    Thread.Sleep(5000);
                    //}
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error parsing " + baseurl + " : " + e);
                }
            }
            using (StreamWriter sw = File.CreateText("ExtraPunctuationURLs.txt"))
                sw.Write(sb);
        }

        public static async Task loadLatestExP()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringReader text;
            using (StreamReader sw = File.OpenText("ExtraPunctuationURLs.txt"))
                text = new StringReader(sw.ReadToEnd());

            StringBuilder sb = new StringBuilder();
            string newl;
            List<string> urls = new List<string>();
            while ((newl = text.ReadLine()) != null && newl.Length != 0)
                urls.Add(newl);

            Console.WriteLine(episodes.episodes.Where(x => x.extrap != null).Select(x => x.extrap.link).Distinct().Count());


            ExtraP exp = await getExP(urls[0]);
            {
                Episode ep = episodes.episodes.FirstOrDefault(x => x.date.Date.AddDays(6).Equals(exp.date.Date));
                if (ep == null)
                {
                    Console.WriteLine("DID NOT MATCH " + urls[0]);
                    //sb.AppendLine(line);
                }
                else
                {
                    ep.extrap = exp;
                }


                Thread.Sleep(3000);
            }


            //using (StreamWriter sw = File.CreateText("ExpNotMatched4.txt"))
            //   sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static async Task loadAllExP()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringReader text;
            using (StreamReader sw = File.OpenText("ExtraPunctuationURLs.txt"))
                text = new StringReader(sw.ReadToEnd());

            StringBuilder sb = new StringBuilder();
            string newl;
            List<string> urls = new List<string>();
            while ((newl = text.ReadLine()) != null && newl.Length != 0)
                urls.Add(newl);

            Console.WriteLine(episodes.episodes.Where(x => x.extrap != null).Select(x => x.extrap.link).Distinct().Count());

            foreach (var line in urls)
            {
                if (episodes.episodes.All(x => x.extrap?.link != line))
                    sb.AppendLine(line);
                /*
                ExtraP exp = await getExP(line);
                Console.WriteLine(exp.title + "|||" + exp.date.DayOfWeek);


                Episode ep = episodes.episodes.FirstOrDefault(x => x.date.Date.AddDays(13).Equals(exp.date.Date));
                if (ep == null)
                {
                    Console.WriteLine("DID NOT MATCH " + line);
                    //sb.AppendLine(line);
                }
                else
                {
                    ep.extrap2 = exp;
                    Console.WriteLine(ep.name + " ||| " +
                                      line.Replace(
                                          "http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/",
                                          ""));
                }


                Thread.Sleep(3000);
                */
            }


            using (StreamWriter sw = File.CreateText("ExpNotMatched4.txt"))
                sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static async Task<ExtraP> getExP(string url)
        {
            try
            {
                WebRequest request = WebRequest.CreateHttp(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse response = await request.GetResponseAsync();

                ExtraP result = new ExtraP();
                result.link = url;

                var htmldoc = new HtmlDocument();
                htmldoc.Load(response.GetResponseStream());
                HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
                result.title = head.Descendants().First(x => x.Name == "meta" && x.Attributes?["name"]?.Value == "title").Attributes["content"].Value;

                HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");
                string datestring = body?.Descendants()
                    .First(x => x.Name == "div" && x.Attributes?["id"]?.Value == "article_content")
                    .Descendants()
                    .First(x => x.Name == "span" && x.Attributes["class"]?.Value == "utc_timestamp")
                    .InnerText;

                result.date = DateTime.Parse(datestring);

                //Console.WriteLine("Parsed page " + url.Replace("http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/",""));

                //foreach (var video in videolinks)
                //{
                //    await fetchEpisode("video");
                //Thread.Sleep(3000);
                //}

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error parsing " + url + " : " + e);
                return null;
            }
        }

        public static async Task loadEpisodes()
        {
            int range = 24;
            var sb = new StringBuilder();
            for (int i = 1; i <= range; i++)
            {
                string baseurl = "http://www.escapistmagazine.com/videos/view/zero-punctuation?page=" + i;
                try
                {
                    WebRequest request = WebRequest.CreateHttp(baseurl);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = await request.GetResponseAsync();

                    var htmldoc = new HtmlDocument();
                    htmldoc.Load(response.GetResponseStream());
                    //HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
                    HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");
                    var videolinks = body?.Descendants()
                        .First(nodes => nodes.Name == "div" && nodes.Attributes["id"]?.Value == "gallery_display").Descendants()
                        .Where(node => node.Attributes["class"]?.Value == "filmstrip_video")
                        .Select(node => node.ChildNodes.First(child => child.Name == "a"))
                        .Select(node => node.Attributes["href"].Value).ToList();

                    Console.WriteLine("Parsed page " + i);
                    Console.WriteLine(string.Join(Environment.NewLine, videolinks));
                    foreach (var video in videolinks)
                        sb.AppendLine(video);
                    //foreach (var video in videolinks)
                    //{
                    //    await fetchEpisode("video");
                    Thread.Sleep(500);
                    //}
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error parsing " + baseurl + " : " + e);
                }
            }
            using (StreamWriter sw = File.CreateText("EscapistURLs.txt"))
                sw.Write(sb);
        }

        public static string slip(string input)
        {
            //return input;
            if (input == null)
                return "";
            string result = input.ToUpper().Trim();

            var romnums = new Dictionary<string, string>()
                                {
                                    {"2", "II" },
                                    {"3", "III" },
                                    {"4", "IV" },
                                    {"5", "V" }
                                };
            foreach (var num in romnums.Keys)
                result = result.Replace(num, romnums[num]);

            if (result.StartsWith("THE "))
                result = result.Substring(4);

            foreach (var c in new[] { ":", "-", "\'", ".", "(", ")", ",", "_", "\"" })
                result = result.Replace(c, "");
            result = result.Replace("&", "AND");
            result = Regex.Replace(result, "\\s+", "").Trim();
            return result;
        }

        public static void YTMerge()
        {
            var objects = new List<JObject>();
            //for (int i = 1; i <= 10; i++)
            //{
            string filename = "Youtube-New.json";
            //string filename = "Youtube-" + i + ".json";
            using (StreamReader sr = File.OpenText(filename))
                objects.Add(JObject.Parse(sr.ReadToEnd()));
            //}
            Dictionary<string, string> yttable = new Dictionary<string, string>();
            foreach (var obj in objects)
                foreach (var item in (JArray)obj["items"])
                {
                    string title = slip(((string)item["snippet"]["title"]).Replace("Zero Punctuation", ""));
                    if (yttable.ContainsKey(title))
                        Console.WriteLine("YT DUPLICATE VID " + title);
                    yttable[title] = (string)item["snippet"]["resourceId"]["videoId"];
                    //Console.WriteLine(title + " - " + yttable[title]);
                }

            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringBuilder sb = new StringBuilder();

            foreach (var episode in episodes.episodes.Where(x => x.number >= 465))
            {
                string key = episode.name;
                if (episode.subtitle != null)
                    key += " - " + episode.subtitle;
                key = slip(episode.name);
                if (yttable.ContainsKey(key))
                    episode.ytlink = "https://www.youtube.com/watch?v=" + yttable[key];
                else if (episode.subtitle != null)
                {
                    key = slip(episode.name + " - " + episode.subtitle);
                    if (yttable.ContainsKey(key))
                        episode.ytlink = "https://www.youtube.com/watch?v=" + yttable[key];
                    else
                        sb.AppendLine("Youtube misses vid " + key);
                }
                else
                    sb.AppendLine("Youtube misses vid " + key);
                yttable.Remove(key);
            }

            foreach (var name in yttable.Keys)
                sb.AppendLine("ESC misses vid " + name);


            Console.WriteLine(sb);
            using (StreamWriter sw = File.CreateText("YT-ESC-Missmatch.txt"))
                sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);

        }

        public static void sortAndAddNumbers()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            Array.Sort(episodes.episodes, (episode1, episode2) => episode1.date.CompareTo(episode2.date));
            for (int i = 0; i < episodes.episodes.Length; i++)
                episodes.episodes[i].number = i + 1;

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static async Task addWikipediaName()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringBuilder sb = new StringBuilder();
            foreach (var episode in episodes.episodes.Where(x => x.number > 465))
                await addWikipediaNames(episode, sb);
            using (StreamWriter sw = File.CreateText("Wikipedia-Missing.txt"))
                sw.Write(sb);
            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        private static async Task addWikipediaNames(Episode episode, StringBuilder sb)
        {
            if (episode.reviewed != null)
                foreach (var review in episode.reviewed)
                {
                    string[] templates = { "{0} ({1} video game)", "{0} (video game)", "{0}", "ROMNUM" };
                    //var results = new Dictionary<string, string>();
                    int k = 0;
                    Console.WriteLine("Testing " + review.name);
                    foreach (var option in templates)
                    {
                        Console.WriteLine("Attempt " + k++);
                        string searcharg;
                        if (option == "ROMNUM")
                        {
                            searcharg = review.name;
                            var romnums = new Dictionary<string, string>()
                            {
                                {"2", "II"},
                                {"3", "III"},
                                {"4", "IV"},
                                {"5", "V"}
                            };
                            foreach (var num in romnums.Keys)
                                searcharg = searcharg.Replace(num, romnums[num]);
                        }
                        else
                            searcharg = string.Format(option, review.name, episode.date.Year);
                        string searchurl =
                            "https://en.wikipedia.org/w/api.php?action=opensearch&profile=normal&limit=3&format=xml&search=" +
                            WebUtility.UrlEncode(searcharg);

                        WebRequest request = WebRequest.CreateHttp(searchurl);
                        request.Credentials = CredentialCache.DefaultCredentials;
                        WebResponse response = await request.GetResponseAsync();

                        var xmldoc = new XmlDocument();
                        xmldoc.Load(response.GetResponseStream());

                        for (int i = 0; i < 3 && i < xmldoc["SearchSuggestion"]["Section"].ChildNodes.Count; i++)
                        {
                            var node = xmldoc["SearchSuggestion"]["Section"].ChildNodes[i];
                            string name = node["Text"]?.InnerText;
                            if (slip(name) == slip(searcharg))
                            {
                                review.wpname = name;
                                Console.WriteLine(episode.name + " | " + name + " | " + node["Description"]?.InnerText);
                                sb.AppendLine(episode.name + " | " + name + " | " + node["Description"]?.InnerText);
                                break;
                            }
                            //results[name] = node["Description"]?.InnerText;
                        }

                        if (review.wpname != null)
                            break;

                        Thread.Sleep(200);
                    }

                    if (review.wpname == null)
                    {
                        Console.WriteLine(episode.name + " | " + review.name + " | " + "| EPISODE MISSING");
                        sb.AppendLine(episode.name + " | " + review.name + " | " + "| EPISODE MISSING");
                    }
                }
        }

        public static void gamecheck()
        {
            StringReader text;
            using (StreamReader sw = File.OpenText("Wikipedia-Missing.txt"))
                text = new StringReader(sw.ReadToEnd());

            string line;
            List<string> nongames = new List<string>();
            List<string> missing = new List<string>();
            while ((line = text.ReadLine()) != null)
                if (line.Contains("EPISODE MISSING"))
                    missing.Add(line);
                else if (!line.ToLower().Contains("game"))
                    nongames.Add(line);
            Console.WriteLine("Non-game: " + nongames.Count);
            foreach (var entry in nongames)
                Console.WriteLine(entry);
            Console.WriteLine();
            Console.WriteLine("Missing: " + missing.Count);
            foreach (var entry in missing)
                Console.WriteLine(entry);

        }

        public static void addGameNames()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var episode in episodes.episodes)
                addGameNames(episode);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        private static void addGameNames(Episode episode)
        {
            if (!episode.name.Contains("Award") && !episode.name.Contains("Holiday") &&
                !episode.name.Contains("Top"))
            {
                if (episode.name.Contains("&") && !episode.name.Contains("Luigi")) //Mario & Luigi games are not double bills
                {
                    var games = episode.name.Split(new[] { "&" }, StringSplitOptions.None);
                    episode.reviewed = new GameReviewed[games.Length];
                    for (int i = 0; i < games.Length; i++)
                    {
                        episode.reviewed[i] = new GameReviewed();
                        episode.reviewed[i].name = games[i].Trim();
                    }
                }
                else if (episode.name.Contains(" and ") && !episode.name.Contains("Salt")) //Salt and Sanctuary
                {
                    var games = episode.name.Split(new[] { "and" }, StringSplitOptions.None);
                    episode.reviewed = new GameReviewed[games.Length];
                    for (int i = 0; i < games.Length; i++)
                    {
                        episode.reviewed[i] = new GameReviewed();
                        episode.reviewed[i].name = games[i].Trim();
                    }
                }
                else
                {
                    episode.reviewed = new GameReviewed[1];
                    episode.reviewed[0] = new GameReviewed();
                    episode.reviewed[0].name = episode.name;
                }
            }
        }

        public static void addReissue()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var episode in episodes.episodes)
            {
                if (episode.name == "Duke Nukem Forever" || episode.name == "Console Rundown" || episode.name.Contains("Guide"))
                {
                    episode.reissue = new Reissue();
                    episode.reissue.date = new DateTime(1990, 05, 10);
                    episode.reissue.esclink = "TODO";
                    episode.reissue.ytlink = "TODO";
                }
            }

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void matchWithWiki()
        {
            MediaWikiType database;
            using (var filestream = new FileStream("ZPLightDB.xml", FileMode.Open))
                database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;

            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            var articles = database.getPages().Where(x => x.isEpisode());

            StringBuilder sb = new StringBuilder();

            foreach (var episode in episodes.episodes)
                if (articles.FirstOrDefault(x => slip(x.title) == slip(episode.name)) == null)
                    sb.AppendLine("WIKI misses episode " + episode.name);

            foreach (var article in articles)
                if (episodes.episodes.FirstOrDefault(x => slip(x.name) == slip(article.title)) == null)
                    sb.AppendLine("DB missed article " + article.title);

            using (StreamWriter sw = File.CreateText("DB-Wiki-Match.txt"))
                sw.Write(sb);
        }

        public static async Task addESCName()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringBuilder sb = new StringBuilder();

            foreach (var episode in episodes.episodes)
                if (episode.esclink != null)
                {
                    WebRequest request = WebRequest.CreateHttp(episode.esclink);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = await request.GetResponseAsync();

                    var htmldoc = new HtmlDocument();
                    htmldoc.Load(response.GetResponseStream());
                    HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
                    HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");

                    episode.originalname =
                        head?.ChildNodes.Where(node => node.Name.Equals("meta"))
                            .FirstOrDefault(
                                node => node.Attributes["name"] != null && node.Attributes["name"].Value.Equals("title"))?
                                .Attributes["content"].Value
                                .Replace("Zero Punctuation :", "").Trim();
                    episode.originalname = WebUtility.HtmlDecode(episode.originalname);
                    if (episode.subtitle != null)
                        episode.originalname = episode.originalname.Replace(episode.subtitle, "").Trim();
                    sb.AppendLine(episode.name + " | " + episode.originalname);
                    Console.WriteLine(episode.name + " | " + episode.originalname);
                    Thread.Sleep(500);
                }

            using (StreamWriter sw = File.CreateText("ESCNameLog.txt"))
                sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void findsub()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var episode in episodes.episodes)
            {
                if (!episode.name.Contains(' '))
                    Console.WriteLine(episode.name + "|");
                if (episode.reviewed != null)
                    foreach (var item in episode.reviewed)
                        if (!item.name.Contains(' '))
                            Console.WriteLine(episode.name + " | " + item.name);
            }
        }

        public static void automatchWithWiki()
        {
            MediaWikiType database;
            using (var filestream = new FileStream("ZPLightDB.xml", FileMode.Open))
                database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;

            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            var articles = database.getPages().Where(x => x.isEpisode());

            StringBuilder sb = new StringBuilder();

            foreach (var episode in episodes.episodes)
            {
                string slipmatch = articles.FirstOrDefault(x => slip(x.title) == slip(episode.name))?.title;
                string exactmatch = articles.FirstOrDefault(x => x.title == episode.name)?.title;
                if (slipmatch != null && exactmatch == null)
                {
                    string oldname = episode.name;
                    sb.AppendLine(oldname + " | " + slipmatch);
                    episode.name = slipmatch;
                }
            }

            using (StreamWriter sw = File.CreateText("DB-Wiki-AutoMatch.txt"))
                sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static Tuple<string, string> unwikipedia(string s)
        {
            string wiki;
            string text;
            var split = s.Split(new[] { " " }, StringSplitOptions.None);
            var titlelist = split.ToList();
            titlelist.RemoveAt(0);
            text = string.Join(" ", titlelist);
            wiki = WebUtility.UrlDecode(split[0].Replace("http://en.wikipedia.org/wiki/", "").Replace("_", " "));
            return new Tuple<string, string>(wiki, text);
        }

        public static void addSongs()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringReader urls;
            using (StreamReader sr = File.OpenText("Songs.txt"))
                urls = new StringReader(sr.ReadToEnd());

            int linenum = 0;
            string url;
            Episode currep = null;
            while ((url = urls.ReadLine()) != null)
            {
                linenum = linenum % 6;
                if (!(linenum == 0 || linenum == 1 || linenum == 3))
                    if (linenum == 2)
                    {
                        currep =
                            episodes.episodes.FirstOrDefault(
                                x => slip(x.name) == slip(url.Replace("|", "").Replace("\'", "").Replace("[", "").Replace("]", "")));
                        if (currep == null)
                            Console.WriteLine("Did not find " + url);
                    }
                    else
                        try
                        {
                            Song song = new Song();

                            var split = url.Split(new[] { " - " }, StringSplitOptions.None);
                            var songname = split[0].Replace("|", "").Replace("\'", "").Replace("[", "").Replace("]", "");
                            var bandname = split[1].Replace("[", "").Replace("]", "");

                            if (songname.Contains("wikipedia"))
                            {
                                var tuple = unwikipedia(songname);
                                song.song = tuple.Item2;
                                song.wpsong = tuple.Item1;
                            }
                            else
                                song.song = songname;

                            if (bandname.Contains("wikipedia"))
                            {
                                var tuple = unwikipedia(bandname);
                                song.band = tuple.Item2;
                                song.wpband = tuple.Item1;
                            }
                            else
                                song.band = bandname;

                            if (linenum == 4)
                                currep.introsong = song;
                            else if (linenum == 5)
                                currep.outrosong = song;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Trouble with Episode " + currep?.name);
                            Console.WriteLine("About line");
                            Console.WriteLine(url);
                            Console.WriteLine(e);
                            Song song = new Song();
                            song.song = "TODO";
                            song.band = "TODO";
                            if (currep != null)
                                if (linenum == 4)
                                    currep.introsong = song;
                                else
                                    currep.outrosong = song;
                        }
                linenum++;
            }

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void addAward()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringReader awards;
            using (StreamReader sw = File.OpenText("awards.csv"))
                awards = new StringReader(sw.ReadToEnd());

            List<GameReviewed> games = new List<GameReviewed>();
            foreach (var game in episodes.episodes)
                if (game.reviewed != null)
                    games.AddRange(game.reviewed);

            string line;
            while ((line = awards.ReadLine()) != null)
            {
                var split = line.Split(new[] { ';' }, StringSplitOptions.None);
                var findings = games.Where(x => x.name == split[0]).ToArray();
                if (findings.Length == 0)
                    Console.WriteLine("ERROR: did not find " + split[0]);
                foreach (var game in findings)
                {
                    if (split[1].StartsWith("\""))
                        split[1] = split[1].Substring(1);
                    if (split[1].EndsWith("\""))
                        split[1] = split[1].Substring(0, split[1].Length - 1);
                    game.awardname = split[1].Replace("\"\"", "\"");
                    game.awardepisode = split[2];
                }
            }

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void readHeadings()
        {
            MediaWikiType database;
            using (var filestream = new FileStream("ZPLightDB.xml", FileMode.Open))
                database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;

            //HashSet<string> headings = new HashSet<string>();
            Dictionary<string, HashSet<string>> headings = new Dictionary<string, HashSet<string>>();
            foreach (var article in database.getEpisodes())
            {
                StringReader sr = new StringReader(article.getText());
                string line;
                while ((line = sr.ReadLine()) != null)
                    if (line.Contains("==") && !line.Contains("==="))
                    {
                        var trimmed = line.Replace("=", "").Trim();
                        if (!headings.ContainsKey(trimmed))
                            headings.Add(trimmed, new HashSet<string>());
                        headings[trimmed].Add(article.title);
                    }
            }
            foreach (var heading in headings)
                Console.WriteLine(heading);
            Console.WriteLine("Found " + headings.Count);
        }

        public static void listCategories()
        {
            MediaWikiType database;
            using (var filestream = new FileStream("ZPLightDB.xml", FileMode.Open))
                database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;

            HashSet<string> categories = new HashSet<string>();
            foreach (var article in database.getEpisodes())
            {
                var text = article.getText();
                var split = text.Split(new[] { "[[Category:" }, StringSplitOptions.None);
                if (split.Length > 1)
                    for (int i = 1; i < split.Length; i++)
                        categories.Add(split[i].Split(new[] { "]]" }, StringSplitOptions.None)[0]);
            }
            foreach (var category in categories)
                Console.WriteLine(category);
            Console.WriteLine("Found " + categories.Count);
        }

        public static void listReviewed()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);
            List<string> reviewed = new List<string>();
            foreach (var episode in episodes.episodes)
                if (episode.reviewed != null)
                    reviewed.AddRange(episode.reviewed.Select(x => x.name));
            reviewed.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (var item in reviewed)
                sb.AppendLine(item);
            sb.AppendLine("Reviewed: " + reviewed.Count);

            using (StreamWriter sw = File.CreateText("ReviewedItems.txt"))
                sw.Write(sb);
        }

        public static void listReviewedMulti()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);
            Dictionary<string, List<string>> rereviewed = new Dictionary<string, List<string>>();
            foreach (var episode in episodes.episodes)
                if (episode.reviewed != null)
                    foreach (var reviewed in episode.reviewed)
                    {
                        if (!rereviewed.ContainsKey(reviewed.name))
                            rereviewed[reviewed.name] = new List<string>();
                        rereviewed[reviewed.name].Add(episode.name);
                    }
            var multireview = rereviewed.Where(x => x.Value.Count > 1);
            foreach (var item in multireview)
            {
                Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
                foreach (var episode in item.Value)
                    episodes.episodes.First(x => x.name == episode).reviewed.First(x => x.name == item.Key).seealso =
                        item.Value.Where(x => x != episode).ToArray();
            }
            //StringBuilder sb = new StringBuilder();
            //foreach (var item in reviewed)
            //    sb.AppendLine(item);
            //sb.AppendLine("Reviewed: " + reviewed.Count);

            //using (StreamWriter sw = File.CreateText("ReviewedItems.txt"))
            //  sw.Write(sb);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void cleanExtraP()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var ep in episodes.episodes.Where(x => x.extrap != null))
                ep.extrap.title = ScrubHtml(ep.extrap.title);

            using (StreamWriter sw = File.CreateText("ZPEpisodeDB.xml"))
                IO.serializer.Serialize(sw, episodes);
        }

        public static void makeInfoboxes()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringBuilder sb = new StringBuilder();
            foreach (var ep in episodes.episodes)
                sb.AppendLine(ep.toWikiaInfobox() + "\n" + ep.teaser + "\n");
            using (StreamWriter sw = File.CreateText("Infoboxes.txt"))
                sw.Write(sb);
        }

        public static void makeNavbar()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            StringBuilder sb = new StringBuilder();
            List<string> included = new List<string>();
            for (int i = 2007; i <= 2017; i++)
            {
                sb.AppendLine(@"{| class=""mw-collapsible mw-collapsed"" style=""width: 100%;""
! colspan=""2"" style=""background: yellow;"" | " + i);
                sb.AppendLine("|-");
                for (int j = 1; j <= 12; j += 3)
                {
                    sb.AppendLine(@"! width=""25%"" style=""background: #FFFF66;"" | Q" + (j + 2) / 3);
                    var matching = episodes.episodes
                            .Where(x => x.date.Year == i)
                            .Where(x => x.date.Month >= j)
                            .Where(x => x.date.Month <= j + 2)
                            .OrderBy(x => x.date)
                            .Select(x => x.name)
                            .Select(x => "[[" + x + "]]")
                        ;
                    included.AddRange(matching);
                    sb.AppendLine("| " + string.Join(" · ", matching));
                    sb.AppendLine("|-");
                }
                sb.AppendLine("|}");
            }

            Console.WriteLine(included.Count);

            using (StreamWriter sw = File.CreateText("Navbar.txt"))
                sw.Write(sb);
        }

        public static void listNonYT()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var s in episodes.episodes.Where(x => x.ytlink == null).Select(x => x.name))
                Console.WriteLine(s);
        }

        public static void listNonWP()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var s in episodes.episodes.Where(x => x.reviewed != null && x.reviewed.Any(y => y.wpname == null)).Select(x => x.name))
                Console.WriteLine(s);
        }

        public static async Task loadAllTranscripts()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var ep in episodes.episodes.Reverse().Where(x => x.ytlink != null))
            {
                await loadTranscriptOfEpisode(ep);
                Thread.Sleep(5000);
            }
        }

        public static async Task loadSecondToLastTranscript()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            var stl = episodes.episodes[episodes.episodes.Length - 2];
            if (string.IsNullOrEmpty(stl.ytlink))
            {
                Console.WriteLine("ERROR: Second to last episode has no YT link");
                return;
            }

            await loadTranscriptOfEpisode(stl);
        }

        public static async Task loadLastTranscript()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            var stl = episodes.episodes[episodes.episodes.Length - 1];
            if (string.IsNullOrEmpty(stl.ytlink))
            {
                Console.WriteLine("ERROR: Last episode has no YT link");
                return;
            }

            await loadTranscriptOfEpisode(stl);
        }

        private static async Task loadTranscriptOfEpisode(Episode ep)
        {
            try
            {
                string videocode = ep.ytlink.Split(new[] { "watch?v=" }, StringSplitOptions.None)[1];
                WebRequest request = WebRequest.CreateHttp("https://video.google.com/timedtext?lang=en&v=" + videocode);
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    string name = "" + ep.number;
                    using (var sw = File.CreateText("transcripts/" + name + ".xml"))
                        sw.Write(text);
                    Console.WriteLine("Wrote " + name + " " + ep.name);
                }
                else
                    Console.WriteLine(response.StatusCode + " for " + ep.name);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error requesting " + ep.name + " : " + e);
            }
        }

        public static void parseTranscripts()
        {
            var dir = Directory.CreateDirectory("transcripts");
            foreach (var file in dir.EnumerateFiles().Where(x => x.Name.EndsWith(".xml")))
            {
                var t = ZPDBProject.YTTranscript.IO.readFile("transcripts/" + file.Name);
                string text = string.Join(" ", t.text.Select(x => x.Value).Where(x => x != null).Select(x =>
                          {
                              x = Regex.Replace(x, @"[\r\n]", " ");
                              if (x.EndsWith(".") || x.EndsWith("!") || x.EndsWith("?") || x.EndsWith("\""))
                                  x += "\n";
                              return x;
                          })
                .Select(WebUtility.HtmlDecode)
                );
                text = Regex.Replace(text, @"  +", " ");
                using (StreamWriter sw = File.CreateText("transcripts/" + file.Name.Replace(".xml", "") + ".txt"))
                    sw.Write(text);
            }
        }

        public static async Task downloadAllEpisodes()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            foreach (var ep in episodes.episodes.Where(x => !string.IsNullOrEmpty(x.esclink)))
                await downloadEP(ep);
        }

        private static async Task downloadEP(Episode ep)
        {
            var list = new List<Tuple<bool, ParsingRequest>>();
            list.Add(new Tuple<bool, ParsingRequest>(false,
                new ParsingRequest(ep.esclink, ParsingRequest.RESOLUTION.R_360P, ParsingRequest.CONTAINER.C_MP4)));
            list.Add(new Tuple<bool, ParsingRequest>(false,
                new ParsingRequest(ep.esclink, ParsingRequest.RESOLUTION.R_480P, ParsingRequest.CONTAINER.C_MP4)));
            list.Add(new Tuple<bool, ParsingRequest>(false,
                new ParsingRequest(ep.esclink, ParsingRequest.RESOLUTION.R_360P, ParsingRequest.CONTAINER.C_WEBM)));
            list.Add(new Tuple<bool, ParsingRequest>(false,
                new ParsingRequest(ep.esclink, ParsingRequest.RESOLUTION.R_480P, ParsingRequest.CONTAINER.C_WEBM)));

            if (!string.IsNullOrEmpty(ep.reissue?.esclink))
            {
                list.Add(new Tuple<bool, ParsingRequest>(true,
                    new ParsingRequest(ep.reissue.esclink, ParsingRequest.RESOLUTION.R_360P, ParsingRequest.CONTAINER.C_MP4)));
                list.Add(new Tuple<bool, ParsingRequest>(true,
                    new ParsingRequest(ep.reissue.esclink, ParsingRequest.RESOLUTION.R_480P, ParsingRequest.CONTAINER.C_MP4)));
                list.Add(new Tuple<bool, ParsingRequest>(true,
                    new ParsingRequest(ep.reissue.esclink, ParsingRequest.RESOLUTION.R_360P, ParsingRequest.CONTAINER.C_WEBM)));
                list.Add(new Tuple<bool, ParsingRequest>(true,
                    new ParsingRequest(ep.reissue.esclink, ParsingRequest.RESOLUTION.R_480P, ParsingRequest.CONTAINER.C_WEBM)));
            }
            Console.Write("" + ep.number + " " + ep.name + " ");
            foreach (var video in list)
            {
                Semaphore semaphore = new Semaphore(0, 1);
                await Grabber.evaluateURL(
                    video.Item2,
                    async exception => Console.WriteLine(exception),
                    () => { },
                    () => { },
                    (async (s, container) =>
                        @"D:\mydata\escapist\"
                        + ((container == ParsingRequest.CONTAINER.C_MP4) ? "MP4" : "WEBM")
                        + (video.Item2.Resolution == ParsingRequest.RESOLUTION.R_360P ? "360" : "480")
                        + "\\" + s + (video.Item1 ? "-REISSUE" : "") + "." +
                        ((container == ParsingRequest.CONTAINER.C_MP4) ? "mp4" : "webm")
                    ),
                    new Downloadhelper(((arg1, arg2) => { }), ((s, b) => semaphore.Release())),
                    async (s) => Console.WriteLine(s),
                    (() => { }),
                    new CancellationToken(false)
                );
                semaphore.WaitOne();
                await Task.Delay(4000);
                Console.Write(" - " + video.Item2.Resolution + " " + video.Item2.Container);
            }
            Console.Write("\n");
        }

        public static async Task downloadLatestEP()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            await downloadEP(episodes.episodes.Last());
        }

        public static void newEPProcedure()
        {
            addLatestEpisode().Wait();
            makeInfoboxes();
            loadSecondToLastTranscript().Wait();
            parseTranscripts();
            downloadLatestEP().Wait();
        }

        public static void countReviewed()
        {
            EpisodeList episodes;
            using (StreamReader sr = File.OpenText("ZPEpisodeDB.xml"))
                episodes = (EpisodeList)IO.serializer.Deserialize(sr);

            HashSet<string> set = new HashSet<string>();
            foreach (var ep in episodes.episodes)
                if (ep.reviewed != null)
            foreach (var rv in ep.reviewed)
                set.Add(rv.name);

            Console.WriteLine(set.Count);
            var list = set.ToList();
            list.Sort();
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public static void Main(string[] args)
        {
            return;
            //loadAllExP().Wait();
            //loadExp().Wait();
            //YTMerge();
            //sortAndAddNumbers();
            //addWikipediaName().Wait();
            //gamecheck();
            //addGameNames();
            //addReissue();
            //matchWithWiki();
            //automatchWithWiki();
            //addESCName().Wait();
            //findsub();
            //addSongs();
            //addLatestEpisode().Wait();
            //listNonYT();
            //listNonWP();
            //countReviewed();
            //loadLatestExP().Wait();
            //cleanExtraP();
            makeInfoboxes();
            //downloadAllEpisodes().Wait();
            //makeNavbar();
            //listCategories();
            //listReviewed();
            //listReviewedMulti();
            //addAward();
            //readHeadings();
            //loadAllTranscripts().Wait();
            //loadSecondToLastTranscript().Wait();
            loadLastTranscript().Wait();
            parseTranscripts();
            //newEPProcedure();
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            //fetchEpisodesFromFile().Wait();
            //fetchEpisode("http://www.escapistmagazine.com/videos/view/zero-punctuation/10168-Splatoon-Ink-Pun").Wait();
        }
    }
}
