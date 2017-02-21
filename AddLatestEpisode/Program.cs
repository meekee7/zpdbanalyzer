using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLatestEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            EscapistFetch.Program.addLatestEpisode().Wait();
        }
    }
}
