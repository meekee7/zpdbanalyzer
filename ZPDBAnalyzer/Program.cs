using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZPDBAnalyzer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            using (var filestream = new FileStream("ZPFullDB.xml", FileMode.Open))
            //using (var filestream = new FileStream("ZPLightDB.xml", FileMode.Open))
            {
                var database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;
                var pages = database.getPages();

                Filtering[] filterings =
                {
                    new Filtering("multispace", x => x.getText().Contains("  ")),
                    new Filtering("zpwiki", x => x.getText().Contains("zeropunctuation.wikia.com")),
                    new Filtering("wikipedia", x => x.getText().Contains("en.wikipedia.org")),
                    new Filtering("novidlink", x => !x.getText().Contains("escapistmagazine.com")),
                    new Filtering("wikia", x =>
                    {
                        var split = x.getText().Split(new[] {".wikia.com"}, StringSplitOptions.None);
                        return split.Any(y => y != split.Last() && !y.EndsWith("zeropunctuation"));
                    }),
                    new Filtering("nolinks", x => !x.getText().Contains('[')),
                    new Filtering("wrongpedia", x =>
                    {
                        var splitA = x.getText().Split(new[] {"wikipedia:"}, StringSplitOptions.None);
                        var splitB = x.getText().Split(new[] {"en.wikipedia.org/wiki/"}, StringSplitOptions.None);
                        return
                            splitA.Any(y =>
                            {
                                if (y == splitA[0])
                                    return false;
                                var titlesplit = y.Split('|');
                                if (titlesplit.Length > 1)
                                {
                                    var title = titlesplit[1].Split(']')[0].Replace("\"", "");
                                    return pages.Any(
                                        z => z.title.Equals(title));
                                }
                                else
                                    return false;
                            })
                            ||
                            splitB.Any(y =>
                            {
                                if (y == splitB[0])
                                    return false;
                                var title = y.Split(' ')[0].Replace('_', ' ').Split('(')[0].TrimEnd();
                                return pages.Any(
                                    z => z.title.Equals(title));
                            });
                    }),
                    new Filtering("linebreaks",
                        x => Regex.IsMatch(x.getText(), "[^\u000a]\u000a\\[^\u000a]")),
                    //new Filtering("Find Grim Fandango", x=> x.getText().Contains("Grim Fandango")), 
                    new Filtering("Not in category Episode", x=> !x.getText().Contains("[[Category:Episode]]") && !x.getText().Contains("[[Category:episode]]")), 
                    new Filtering("empty text", x=> x.getText() == String.Empty), 
                    new Filtering("noaddenda", x=> !x.getText().Contains("Addend") && !x.getText().Contains("Credits")),     
                    //x => x.getText().Contains("\u000a\u000a\u000a")),
                    //x => Regex.IsMatch(x.getText(), "[^\u000a]*\u000a(\u000a\u000a)*[^\u000a]*")),
                };

                
                Parallel.ForEach(filterings, x => x.results = pages.Where(x.filterfunc));
                //foreach (var analysis in filterings)
                //  analysis.results = pages.Where(analysis.filterfunc);

                if (true)
                    foreach (var analysis in filterings)
                    {
                        Console.WriteLine(analysis.name + " (" + analysis.results.Count() + "):");
                        foreach (var page in analysis.results)
                            Console.WriteLine(page.title);
                        Console.WriteLine();
                    }

                Console.WriteLine("Total results:");
                Console.WriteLine("Total pages: " + pages.Count());
                foreach (var analysis in filterings)
                    Console.WriteLine(analysis.name + ": " + analysis.results.Count());
                Console.WriteLine();
            }

            if (false)
            {
                XDocument fulldb = XDocument.Load("ZPFullDB.xml");
                XDocument articles = Processing.getArticles(fulldb);
                articles.Save("ZPArticles.xml");
            }

            //XDocument withdoublespace = Processing.getWithMultiSpace(articles);
            //withdoublespace.Save("doublespace.xml");
            
            DateTime end = DateTime.Now;
            Console.WriteLine("Run in " + (end - start));
            Console.WriteLine("Processing complete. Hit any key to exit.");
            Console.ReadKey();
        }
    }

    internal class Processing
    {
        public static XDocument getArticles(XDocument basedoc)
        {
            var result = new XDocument();
            var rootnode = new XElement(XName.Get("articles"));
            IEnumerable<XElement> pages = basedoc.Descendants()
                .Where(
                    x =>
                        x.Name.LocalName.Equals("page") &&
                        x.Descendants().First(y => y.Name.LocalName.Equals("ns")).Value.Equals("0") &&
                        x.Descendants().FirstOrDefault(z => z.Name.LocalName.Equals("redirect title")) == null);
            rootnode.Add(pages);
            foreach (XElement page in pages)
                rootnode.Add(page);

            result.Add(rootnode);
            Console.WriteLine(pages.ToArray().Length + " articles detected");
            return result;
        }

        public static XDocument getWithMultiSpace(XDocument articles)
        {
            var result = new XDocument();
            IEnumerable<XElement> pages = articles.Descendants().Where(
                x =>
                {
                    XElement revision =
                        x.Descendants().FirstOrDefault(y => y.Name.LocalName.Equals("revision"));
                    if (revision == null)
                        Console.WriteLine("Name :" +
                                          x.Descendants().FirstOrDefault(y => y.Name.LocalName.Equals("title")).Value);
                    return true;
                    //    x.Descendants().FirstOrDefault(z => z.Name.LocalName.Equals("redirect title")) == null
                    ;
                    // var revision = x.Descendants().First(y => y.Name.LocalName.Equals("revision"));
                    //var text = revision.Descendants().First(z => z.Name.LocalName.Equals("text"));
                    //return text.Value.Contains("  ");
                });
            var rootnode = new XElement(XName.Get("articles"));
            //foreach (XElement page in pages)
            //  Console.WriteLine(page.Descendants().First(x => x.Name.LocalName.Equals("title")).Value);
            rootnode.Add(pages);
            result.Add(rootnode);
            return result;
        }
    }
}