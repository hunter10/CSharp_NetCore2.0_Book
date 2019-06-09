using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public partial class Person
    {
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;


        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 5);
        }

        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;

            x++;
            y++;
            z++;
        }
    }
}
