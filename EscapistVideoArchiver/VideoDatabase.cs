using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace EscapistVideoArchiver
{
    public static class SitemapIO
    {
        public static readonly XmlSerializer serializer = new XmlSerializer(typeof(urlset));

        public static urlset readFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
                return (urlset)SitemapIO.serializer.Deserialize(sr);
        }

        public static void writeFile(string filename, urlset urlset)
        {
            using (StreamWriter sw = File.CreateText(filename))
                SitemapIO.serializer.Serialize(sw, urlset);
        }
    }

    public static class VideoIO
    {
        public static readonly XmlSerializer serializer = new XmlSerializer(typeof(VideoList));

        public static VideoList readFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
                return (VideoList)VideoIO.serializer.Deserialize(sr);
        }

        public static void writeFile(string filename, VideoList videos)
        {
            using (StreamWriter sw = File.CreateText(filename))
                VideoIO.serializer.Serialize(sw, videos);
        }
    }

    [XmlRoot]
    public class VideoList
    {
        [XmlArray]
        public Video[] videos;
    }

    public class Video
    {
        [XmlAttribute]
        public int number;
        [XmlAttribute]
        public string escurl;
        [XmlAttribute]
        public string yturl;
        [XmlAttribute]
        public string title;
        [XmlAttribute]
        public DateTime date;
        [XmlAttribute]
        public int length;
        [XmlAttribute]
        public string teaser;
    }

    public class Utils
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

        public static async Task<Video> fetchVideoData(string url)
        {
            Video video = new Video();

            video.escurl = url;

            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("age_gate_birthday", "19870313","/","escapistmagazine.com"));
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = await request.GetResponseAsync();

            var htmldoc = new HtmlDocument();
            htmldoc.Load(response.GetResponseStream());
            HtmlNode head = htmldoc.DocumentNode.ChildNodes.FindFirst("head");
            HtmlNode body = htmldoc.DocumentNode.ChildNodes.FindFirst("body");

            video.title = ScrubHtml(
                head?.ChildNodes.Where(node => node.Name.Equals("meta"))
                    .FirstOrDefault(
                        node => node.Attributes["name"] != null && node.Attributes["name"].Value.Equals("title"))?
                    .Attributes["content"].Value.Trim());

            string teaser = body?.Descendants()
                .First(x => x.Name == "span" && x.Attributes["itemprop"]?.Value == "description")?.FirstChild.InnerHtml;
            if (teaser != null)
                video.teaser = ScrubHtml(teaser);

            string datestring = body?.Descendants().Where(node => node.Name == "span")
                .First(node => node.Attributes["class"]?.Value == "publish_time").ChildNodes
                .First(node => node.Attributes["class"]?.Value == "utc_timestamp").InnerText;
            video.date = DateTime.Parse(datestring);

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
                video.length = (int)config["videoData"]["duration"] / 1000;
            }

            return video;
        }
    }
}