using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace H1GPDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converting Celsius to Fahrenheit.

            TemperatureConverter converter1 = new TemperatureConverter();
            Console.Write("How hot is it in Celcius? ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = converter1.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"\n{celsius} degree Celsius is equal to {fahrenheit} degree Fahrenheit ");
            Console.ReadLine();

            Console.Clear();

            //Converting Fahrenheit to Celsius.

            TemperatureConverter converter2 = new TemperatureConverter();
            Console.Write("How hot is it in Fahrenheit? ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = converter2.FahrenheitToCelcius(fahrenheit);
            Console.WriteLine($"\n{fahrenheit} degree Fahrenheit is equal to {celsius} degree Celsius");
            Console.ReadLine();

            Console.Clear();

        }
    }
}
