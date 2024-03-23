using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de termeni");
            //int n = int.Parse(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            //Alta metoda:Try.Parse
            for (int i = 0; i < n; i++)
                Console.WriteLine("Termenul {0} este {1}",i,Fibonacci(i));
        }

        static public int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
