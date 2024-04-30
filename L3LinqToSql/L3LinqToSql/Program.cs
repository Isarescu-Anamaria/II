using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3LinqToSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    var query = from Universitati in db.Universitatis select new
                    {
                        universitati = Universitati.Id,
                        city = Universitati.City,
                        code = Universitati.Code
                    };
                    foreach (var c in query)
                    {
                        Console.WriteLine("vbTab {0} vbTab {1}", c.universitati, c.city);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
