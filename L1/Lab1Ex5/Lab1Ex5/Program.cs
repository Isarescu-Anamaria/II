using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti {0} numere: ", n);
            for (int i = 0; i < n; i++)
            {
                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Vectorul este: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            Medii medie = new Medii();

            Console.WriteLine("Media aritmetica a numerelor este: ");
            double ma = medie.MediaAritmetica(v, n);
            medie.AfisareMedie(ma);

            Console.WriteLine("Media geometrica a numerelor este: ");
            double mg = medie.MediaGeometrica(v, n);
            medie.AfisareMedie(mg);
        }
    }
}
