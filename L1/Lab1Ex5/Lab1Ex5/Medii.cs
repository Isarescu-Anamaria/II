using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex5
{
    internal class Medii
    {
        public double MediaAritmetica(int [] v, int n)
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += v[i];
            }
            double ma = suma / n;
            return ma;
        }
        public double MediaGeometrica(int[] v, int n)
        {
            double produs = 1;
            for (int i = 0; i < n; i++)
            {
                produs *= v[i];
            }
            double mg = Math.Pow(produs,1/n);
            return mg;
        }
        public void AfisareMedie(double medie)
        {
            Console.WriteLine("Media este : {0}", medie);
        }
    }
}
