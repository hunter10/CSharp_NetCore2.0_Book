using System;

namespace Packt.CS7
{
    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;

        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 5);
        }

        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }
    }
}
    