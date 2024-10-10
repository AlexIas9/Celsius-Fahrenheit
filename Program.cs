using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Conversie Celsius în Fahrenheit");
            Console.WriteLine("2. Conversie Fahrenheit în Celsius");
            Console.Write("Selectati optiunea (1 sau 2): ");

            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1:
                    ConversieCelsiusToFahrenheit();
                    break;
                case 2:
                    ConversieFahrenheitToCelsius();
                    break;
                default:
                    Console.WriteLine("Opțiune invalida. Vă rugam să introduceti 1 sau 2.");
                    break;
            }
            Console.ReadLine();
        }
        static void ConversieCelsiusToFahrenheit()
        {
            Console.Write("Introduceti temperatura în grade Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            Console.WriteLine($"Temperatura în grade Fahrenheit: {temperaturaFahrenheit}");
        }

        static void ConversieFahrenheitToCelsius()
        {
            Console.Write("Introduceti temperatura în grade Fahrenheit: ");
            double temperaturaFahrenheit = double.Parse(Console.ReadLine());

            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatura în grade Celsius: {temperaturaCelsius}");
        }
    }
}
