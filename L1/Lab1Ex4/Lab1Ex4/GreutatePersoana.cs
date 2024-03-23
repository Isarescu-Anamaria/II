using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex4
{
    internal class GreutatePersoana
    {
        public double CalculGreutateFemei(int inaltime, int varsta)
        {
            double greutate = (inaltime - 100 - ((inaltime - 150) / 2.5)) + ((varsta - 20) / 4);
            return greutate;
        }
        public double CalculGreutateBarbati(int inaltime, int varsta)
        {
            double greutate = (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
            return greutate;
        }
        public void AfisareGreutateIdeala(double greutate)
        {
            Console.WriteLine("Greutatea ideala este: {0} kg", greutate);
        }
    }
}
