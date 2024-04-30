using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 web = new localhost.WebService1();
            Console.WriteLine(web.CtoF(30));
            Console.WriteLine(web.FtoC(100));
            Console.WriteLine(web.Data());
            string[] test = web.Afis();
            for(int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine(web.Afis());
            Console.WriteLine(web.ConvertMoney(5));
        }
    }
}
