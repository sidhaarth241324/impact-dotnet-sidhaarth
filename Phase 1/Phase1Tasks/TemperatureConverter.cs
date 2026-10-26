using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class TemperatureConverter
    {
        public void Convert(double celsius, string unit)
        {  // Celsius input
            if (unit == "C")
            {
                Console.WriteLine($"Fahrenheit: {(celsius * 9 / 5) + 32} °F");
                Console.WriteLine($"Kelvin: {celsius + 273.15} K");
            }
        }
        // Fahrenheit input
        public void Convert(string unit, double fahrenheit)
        {
            if (unit == "F")
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Celsius: {celsius:F2} °C");
                Console.WriteLine($"Kelvin: {celsius + 273.15:F2} K");
            }
        }
        // Kelvin input
        public void Convert(double kelvin, int unit)
        {
            if (unit == 1)
            {
                double celsius = kelvin - 273.15;
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"Celsius: {celsius:F2} °C");
                Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
            }
        }

    }
}
