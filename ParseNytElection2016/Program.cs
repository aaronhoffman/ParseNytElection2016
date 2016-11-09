using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNytElection2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new NytParser();
            p.ParseJsonFile(@"C:\eln_races.json");
        }
    }
}
