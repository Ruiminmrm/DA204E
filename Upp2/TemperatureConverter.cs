using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upp2
{
    internal class TemperatureConverter
    {
        /*  F = 9/5.0 * C + 32 
            C = 5/9.0 *(F - 32) 
        */
        const int maxCelsius = 100;
        const int maxFarenheit = 212;
        //use the convertion formulas
        private double CelsiusToFarenheit(double celsius)
        {
            double farenheit = 9 / 5.0 * celsius + 32;
            return farenheit;
        }
        private double FarenheitToCelsius(double farenheit)
        {
            double celsius = 5 / 9.0 * (farenheit - 32);
            return celsius;
        }
        private void ShowMenu()
        {
            Console.WriteLine("----------MAIN MENU----------");
            Console.WriteLine("Celsius to Fahrenheit : 1");
            Console.WriteLine("Fahrenheit to Celsius : 2");
            Console.WriteLine("Exit the program      : 3");
            Console.WriteLine("-----------------------------");

            Console.Write("Your choice : ");
            //use switch
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowTableCelsiusToFahrenheit();
                    break;
                case "2":
                    ShowTableFarenheitToCelsius();
                    break;
                case"3":
                    break;
            }
        }
        private void ShowTableCelsiusToFahrenheit()
        {
            for(int i = 0; i <= maxCelsius; i = i + 4)
            {
                //{0:N2} is for two significant digit
                Console.WriteLine(string.Format("{0:N2}",i) + " C = " + string.Format("{0:N2}",CelsiusToFarenheit((double)i)) + " F");
            }
        }
        private void ShowTableFarenheitToCelsius()
        {
            for (int i = 0; i <= maxFarenheit; i = i + 10)
            {
                //{0:N2} is for two significant digit
                Console.WriteLine(string.Format("{0:N2}", i) + " F = " + string.Format("{0:N2}", FarenheitToCelsius((double)i)) + " C");
            }
        }
        public void Start()
        {
            bool runapp = true;
            do
            {
                ShowMenu();
                Console.WriteLine("Exit the program ? (y/n)");
                string a = Console.ReadLine();
                if (a == "y")
                    runapp = false;
            } while (runapp);
        }
    }
}
