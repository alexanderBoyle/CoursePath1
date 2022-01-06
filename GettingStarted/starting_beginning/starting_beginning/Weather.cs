using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starting_beginning
{
    class Weather
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }
        static public float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return (temperatureCelsius * 1.8f) + 32;
        }

        //Higher Index less comfort
        static public float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            //Probaly not a very reliabble formula:
            //trying out test for Github 
            return (temperatureFahrenheit + humidityPercent) / 4;
        }
        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            float temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}
