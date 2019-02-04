using System;
using static System.Console;

namespace Ch04_ManipulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third is {city[2]}");

            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach(string item in citiesArray)
            {
                WriteLine(item);
            }

            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);
        }
    }
}
