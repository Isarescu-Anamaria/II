using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti metoda de calcul dorita(M sau F)");
            char gen = Convert.ToChar(Console.ReadLine());

            bool alegereValida = false;

            while (alegereValida == false)
            {
                if (gen == 'F' || gen == 'M')
                {
                    Console.WriteLine("Optiune valida");
                    alegereValida = true;
                }
                else
                {
                    Console.WriteLine("Aceasta optiune nu exista!Alegeti din nou!");
                    gen = Convert.ToChar(Console.ReadLine());
                }
            }

            Console.WriteLine("Introduceti inaltimea");
            int inaltime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti varsta");
            int varsta = Convert.ToInt32(Console.ReadLine());

            GreutatePersoana greutatePersoana = new GreutatePersoana(); 

            if (gen == 'F')
            {
                double greutateIdeala = greutatePersoana.CalculGreutateFemei(inaltime,varsta);
                greutatePersoana.AfisareGreutateIdeala(greutateIdeala);
            }

            if (gen == 'M')
            {
                double greutateIdeala = greutatePersoana.CalculGreutateBarbati(inaltime, varsta);
                greutatePersoana.AfisareGreutateIdeala(greutateIdeala);
            }
        }
    }
}
