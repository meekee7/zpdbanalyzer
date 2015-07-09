using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ZPDBAnalyzer
{
    public partial class PageType
    {
        public String getText()
        {
            return (this.Items.Last() as RevisionType).text.Value ?? String.Empty;
        }
    }

    public partial class MediaWikiType
    {
        public static XmlSerializer serializer = new XmlSerializer(typeof (MediaWikiType));

        public IEnumerable<PageType> getPages()
        {
            return this.page.Where(x => x.ns == "0" && x.redirect == null);
        }
    }

    public class Filtering
    {
        public String name;
        public IEnumerable<PageType> results;
        public Func<PageType, bool> filterfunc;

        public Filtering(string name, Func<PageType, bool> filterfunc)
        {
            this.name = name;
            this.filterfunc = filterfunc;
        }
    }
}