using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1GPDay1
{
    public class TemperatureConverter
    {
        //My method on how to convert Celsius to Fahrenheit.

        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        //My method on how to convert Fahrenheit to Celsius.

        public double FahrenheitToCelcius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
