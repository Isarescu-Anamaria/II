using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4nou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = 0;
            int maxRows = 20;

            using(Database1Entities entities = new Database1Entities())
            {
                IList<Universitati> exList = (from Universitati in entities.Universitatis select Universitati)
                    .OrderBy(Universitati => Universitati.Id)
                    .Skip(startIndex)
                    .Take(maxRows).ToList();
                foreach (Universitati universitati in exList)
                {
                    Console.WriteLine(universitati.NameUniv);
                    Console.WriteLine(" " + universitati.City);
                    Console.WriteLine(" " + universitati.Code);

                }
            }
        }
    }
}
