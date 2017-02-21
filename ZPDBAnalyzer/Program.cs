using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //using (var filestream = new FileStream("ZPFullDB.xml", FileMode.Open))
            using (var filestream = new FileStream("C:\\Users\\Michael\\Documents\\Visual Studio 2013\\Projects\\ZPDBAnalyzer\\EscapistFetch\\bin\\Debug\\ZPLightDB.xml", FileMode.Open))
            {
                var database = MediaWikiType.serializer.Deserialize(filestream) as MediaWikiType;
                var pages = database.getEpisodes();

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
                    new Filtering("Not in category Episode", x=> !x.isEpisode()), 
                    new Filtering("empty text", x=> x.getText() == string.Empty), 
                    new Filtering("noaddenda", x=> !x.getText().Contains("Addend") && !x.getText().Contains("Credits")),     
                    new Filtering("notranscript", x=> !x.getText().Replace(" ","").Contains("==Transcript==")),
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

            DateTime end = DateTime.Now;
            Console.WriteLine("Run in " + (end - start));
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Processing complete. Hit any key to exit.");
                Console.ReadKey();
            }
        }
    }
    
}