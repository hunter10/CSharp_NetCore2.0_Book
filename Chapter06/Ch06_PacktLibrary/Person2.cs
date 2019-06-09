namespace Packt.CS7
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => (int)(System.DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);

        public Person this[int index]
        {
            get{
                return Children[index];
            }

            set{
                Children[index] = value;
            }
        }
    }
}