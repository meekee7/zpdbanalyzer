using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZPDBProject
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
        [XmlAttribute] public string title;
        [XmlAttribute] public string link;
        [XmlAttribute] public DateTime date;
    }

    public class Song
    {
        [XmlAttribute] public string band;
        [XmlAttribute] public string wpband;
        [XmlAttribute] public string song;
        [XmlAttribute] public string wpsong;
    }

    public class Reissue
    {
        [XmlAttribute] public DateTime date;
        [XmlAttribute] public string esclink;
        [XmlAttribute] public string ytlink;
    }

    public class GameReviewed
    {
        [XmlAttribute] public string name;
        [XmlAttribute] public string wpname;
        [XmlAttribute] public string awardname;
        [XmlAttribute] public string awardepisode; //Reference to an episode name
        [XmlElement] public string[] seealso; //References to episode names
    }

    [XmlRoot]
    public class EpisodeList
    {
        [XmlArray] public Episode[] episodes;
    }

    public class Episode
    {
        [XmlAttribute] public string name;
        [XmlAttribute] public int number;
        [XmlAttribute] public int length; //Seconds
        [XmlAttribute] public string esclink;
        [XmlAttribute] public string originalname;
        [XmlAttribute] public string ytlink;
        [XmlAttribute] public DateTime date;
        [XmlAttribute] public string subtitle;
        [XmlElement] public ExtraP extrap;
        [XmlElement] public Reissue reissue;
        [XmlElement] public Song introsong;
        [XmlElement] public Song outrosong;
        
        [XmlElement] public GameReviewed[] reviewed;
        [XmlElement] public string teaser;
        [XmlElement] public string transcript;
        [XmlElement] public string[] addenda;
        [XmlElement] public string categories;
        [XmlElement] public string othercontent;
    }
}
