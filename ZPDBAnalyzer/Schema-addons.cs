using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ZPDBAnalyzer
{
    public partial class PageType
    {
        public string getText()
        {
            return (this.Items.Last() as RevisionType).text.Value ?? string.Empty;
        }

        public bool isEpisode()
        {
            return this.getText().Contains("[[Category:Episode") || this.getText().Contains("[[Category:episode");
        }
    }

    public partial class MediaWikiType
    {
        public static XmlSerializer serializer = new XmlSerializer(typeof (MediaWikiType));

        public List<PageType> getPages()
        {
            return this.page.Where(x => x.ns == "0" && x.redirect == null).ToList();
        }

        public List<PageType> getEpisodes()
        {
            return this.page.Where(x => x.ns == "0" && x.redirect == null && x.isEpisode()).ToList();
        }
    }

    public class Filtering
    {
        public string name;
        public IEnumerable<PageType> results;
        public Func<PageType, bool> filterfunc;

        public Filtering(string name, Func<PageType, bool> filterfunc)
        {
            this.name = name;
            this.filterfunc = filterfunc;
        }
    }
}