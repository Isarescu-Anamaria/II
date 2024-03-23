using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operatii ob = new Operatii();
            Console.WriteLine("Introduceti primul numar real: ");
            double nr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar real: ");
            double nr2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti una din operatiile(+ - * /) sau q pentru iesire: ");
            char op = Convert.ToChar(Console.ReadLine());

            while(op != 'q')
            {
                switch (op)
                {
                    case '+':
                        ob.Afisare(nr1, nr2, op, ob.Adunare(nr1, nr2));
                        break;

                    case '-':
                        ob.Afisare(nr1, nr2, op, ob.Scadere(nr1, nr2));
                        break;

                    case '*':
                        ob.Afisare(nr1, nr2, op, ob.Inmultire(nr1, nr2));
                        break;

                    case '/':
                        ob.Afisare(nr1, nr2, op, ob.Impartire(nr1, nr2));
                        break;

                    default: Console.WriteLine("Introduceti o operatie valida!");
                        break;
                }
                Console.WriteLine("Introduceti una din operatiile(+ - * /) sau q pentru iesire: ");
                op = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
