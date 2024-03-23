using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea temperaturii: ");
            double tempValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti conversia dorita(c pentru a converti din grade Farenheit in grade Celsius)");
            Console.WriteLine("Introduceti conversia dorita(f pentru conversia din grade Celsius in grade Farenheit)");
            Console.WriteLine("Introduceti q pentru a iesi!");

            Temperaturi temp = new Temperaturi();

            char degreeType = Convert.ToChar(Console.ReadLine());

            while (degreeType != 'q')
            {
                switch (degreeType)
                {
                    case 'c':
                        temp.FarenheitToCelsius(tempValue);
                        break;

                    case 'f':
                        temp.CelsiusToFarenheit(tempValue);
                        break;
                    default:
                        Console.WriteLine("Alegeti o optiune valida!");
                        break;
                }
                Console.WriteLine("Introduceti o noua optiune: ");
                degreeType = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}
