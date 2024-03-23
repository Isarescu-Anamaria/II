using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Ex3
{
    internal class Temperaturi
    {
        public void CelsiusToFarenheit(double celsius)
        {
            double temperature =  (celsius * (9 / 5)) + 32;
            Console.WriteLine("Temperatura in grade Farenheit este {0} :", temperature);
        }
        public void FarenheitToCelsius(double farenheit)
        {
            double temperature =  (farenheit - 32) * (5 / 9);
            Console.WriteLine("Temperatura in grade Celsius este {0} :", temperature);
        }
        
    }
}
