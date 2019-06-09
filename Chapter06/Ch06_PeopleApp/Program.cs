using Packt.CS7;
using System;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1965,12,22);
            p1.FavouriteAncientWonder =
                WondersOfTheAncientWorld.SattueOfZeusAtOlympia;
            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} is a {Person.Species}");
            WriteLine($"{p1.Name} was born on {p1.HomePlanet}");
            //WriteLine($"{p1.Name} has {p1.Children.Count} children.");
            //WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");    
            //WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");
            //WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM, yyyy}");

            //var p2 = new Person { Name = "Alice Jones", DateOfBirth = new
            //    DateTime(1998, 3, 17)};
            //WriteLine($"{p2.Name} was born on {p2.DateOfBirth:d MMM yy}");
            

            /*
            BankAccount.InterestRate = 0.5M;

            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 1000;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest.");
            

            var ba2 = new BankAccount();
            ba2.AccountName = "Mrs. Gerrier";
            ba2.Balance = 900;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");
            */


            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiate at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            WriteLine($"{p3.GetFruitCS4().Item1}, {p3.GetFruitCS4().Item2}.");
            WriteLine($"{p3.GetFruitCS7().Item2}, {p3.GetFruitCS7().Item1}.");

            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a={a}, b={b}, c={c}");
            p3.PassingParameters(a, ref b, out c);
            WriteLine($"After: a={a}, b={b}, c={c}");

            int d = 10;
            int e = 20;
            WriteLine($"Before: d={d}, e={e}");
            p3.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d={d}, e={e}, f={f}");

            var max = new Person
            {
                Name = "Max",
                DateOfBirth = new DateTime(1972,1,27)
            };

            WriteLine(max.Origin);
            WriteLine(max.Greeting);
            WriteLine(max.Age);

            max.Children.Add(new Person {Name="Charlie"});
            max.Children.Add(new Person {Name="Ella"});
            WriteLine($"Max's first child is {max.Children[0].Name}");
            WriteLine($"Max's second child is {max.Children[1].Name}");
            WriteLine($"Max's first child is {max[0].Name}");
            WriteLine($"Max's second child is {max[1].Name}");
        }
    }
}
