using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WikiaInsertionBrowser
{
    public static class IO
    {
        public static readonly XmlSerializer serializer = new XmlSerializer(typeof(EpisodeList));

        public static EpisodeList readFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
                return (EpisodeList)IO.serializer.Deserialize(sr);
        }

        public static void writeFile(string filename, EpisodeList episodes)
        {
            using (StreamWriter sw = File.CreateText(filename))
                IO.serializer.Serialize(sw, episodes);
        }
    }

    public class ExtraP
    {
        [XmlAttribute]
        public string title;
        [XmlAttribute]
        public string link;
        [XmlAttribute]
        public DateTime date;
    }

    public class Song
    {
        [XmlAttribute]
        public string band;
        [XmlAttribute]
        public string wpband;
        [XmlAttribute]
        public string song;
        [XmlAttribute]
        public string wpsong;

        public string toWikiaString()
        {
            StringBuilder sb = new StringBuilder();
            if (wpsong == null)
                sb.Append("''" + this.song + "''");
            else
                sb.Append("''[[wikipedia:" + this.wpsong + " | " + this.song + "]]''");
            sb.Append(" - ");
            if (wpband == null)
                sb.Append(this.band);
            else
                sb.Append("[[wikipedia:" + this.wpband + " | " + this.band + "]]");
            return sb.ToString();
        }
    }

    public class Reissue
    {
        [XmlAttribute]
        public DateTime date;
        [XmlAttribute]
        public string esclink;
        [XmlAttribute]
        public string ytlink;
    }

    public class GameReviewed
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string wpname;
        [XmlAttribute]
        public string awardname;
        [XmlAttribute]
        public string awardepisode; //Reference to an episode name
        [XmlElement]
        public string[] seealso; //References to episode names

        public string getWikiaNameString()
        {
            return this.wpname == null ? this.name : "''[[wikipedia:" + this.wpname + " | " + this.name + "]]''";
        }

        public string getWikiaAwardString()
        {
            return "[[" + awardepisode + " | " + awardname + "]]";
        }
    }

    [XmlRoot]
    public class EpisodeList
    {
        [XmlArray]
        public Episode[] episodes;
    }

    public class Episode
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public int number;
        [XmlAttribute]
        public int length; //Seconds
        [XmlAttribute]
        public string esclink;
        [XmlAttribute]
        public string originalname;
        [XmlAttribute]
        public string ytlink;
        [XmlAttribute]
        public DateTime date;
        [XmlAttribute]
        public string subtitle;
        [XmlElement]
        public ExtraP extrap;
        [XmlElement]
        public Reissue reissue;
        [XmlElement]
        public Song introsong;
        [XmlElement]
        public Song outrosong;

        [XmlElement]
        public GameReviewed[] reviewed;
        [XmlElement]
        public string teaser;
        [XmlElement]
        public string transcript;
        [XmlElement]
        public string[] addenda;
        [XmlElement]
        public string categories;
        [XmlElement]
        public string othercontent;

        public override string ToString()
        {
            return this.number + " " + this.name;
        }

        public string lengthString()
        {
            return this.length / 60 + ":" + (this.length % 60 < 10 ? "0" : "") + this.length % 60;
        }

        public string reviewedstring()
        {
            return this.reviewed == null ? "N/A"
                : string.Join(", ", this.reviewed.Select(x => x.getWikiaNameString()));
        }

        public string awardstring()
        {
            if (this.reviewed == null)
                return "";
            GameReviewed rv = this.reviewed.FirstOrDefault(x => x.awardname != null);
            if (rv == null)
                return "";
            string result = rv.getWikiaAwardString();
            if (this.reviewed.Length > 1)
                result += " for ''" + rv.name + "''";
            return result;
        }

        public string seealsostring()
        {
            return this.reviewed == null ? "" :
            string.Join(", ", this.reviewed
                .Where(x => x.seealso != null)
                .Select(x => x.seealso[0])
                .Select(x => "[[" + x + "]]")
                );
        }

        public string toWikiaInfobox()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{{StandardInfobox");
            //| title1 = Example
            //| image1 = Example
            //| caption1 = Example
            sb.Append("| number = " + this.number);
            sb.Append("| length = " + this.lengthString());
            sb.Append("| date = " + this.date.ToString("yyyy-MM-dd"));
            if (this.reissue != null)
                sb.Append(", reissued " + this.reissue.date.ToString("yyyy-MM-dd"));
            if (this.subtitle != null)
                sb.Append("| subtitle = " + this.subtitle);
            if (this.esclink != null)
                if (this.reissue?.esclink == null)
                    sb.Append("| escapist = [" + this.esclink + " Escapist]");
                else
                    sb.Append("| escapist = [" + this.esclink + " Original], [" + this.reissue.esclink + " Reissue]");
            if (this.ytlink != null)
                if (this.reissue?.esclink == null)
                    sb.Append("| youtube = [" + this.ytlink + " Youtube]");
                else
                    sb.Append("| youtube = [" + this.ytlink + " Original], [" + this.reissue.ytlink + " Reissue]");
            if (this.extrap != null)
                sb.Append("| extra_punctuation = " + "[" + this.extrap.link + " " + this.extrap.title + "]");

            string reviewedstring = this.reviewedstring();
            sb.Append("| reviewed = " + reviewedstring);

            string awardstring = this.awardstring();
            if (awardstring.Length != 0)
                sb.Append("| award = " + awardstring);

            string seealso = this.seealsostring();
            if (seealso.Length != 0)
                sb.Append("| see_also = " + seealso);

            if (this.introsong != null)
                sb.Append("| intro = " + this.introsong.toWikiaString());
            if (this.outrosong != null)
                sb.Append("| outro = " + this.outrosong.toWikiaString());

            sb.Append("}}");
            return sb.ToString();
        }
    }
}
