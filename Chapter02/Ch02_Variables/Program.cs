using System;
using static System.Console;

namespace Ch03_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            WriteLine($"Hello {firstName}, you look good for {age}");
        }
    }
}
