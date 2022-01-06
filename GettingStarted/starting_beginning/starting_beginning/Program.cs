using System;


namespace starting_beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            Weather.Report("San Francisco", Weather.FahrenheitToCelsius(65), 73);
            Weather.Report("Denver", Weather.FahrenheitToCelsius(77), 55);
            Weather.Report("Bologna", 23, 65);

            //Console.WriteLine(FahrenheitToCelsius(80).ToString("0.0"));
            
            //string[] interestingAnimals = { "Aardvark", "Binturong", "Pangolin" };
            //string anInterestingAnimal = interestingAnimals[0];
            //Console.WriteLine(anInterestingAnimal);
        }
    }
}
