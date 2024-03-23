using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex2
{
    internal class Operatii
    {
        public double Adunare(double a, double b)
        {
            return a + b;
        }
        public double Scadere(double a, double b)
        {
            return a - b;
        }
        public double Inmultire(double a, double b)
        {
            return a * b;
        }
        public double Impartire(double a, double b)
        {
            return a / b;
        }
        public void Afisare(double a, double b, char op, double rez) 
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, op, b, rez);
        }
    }
}
