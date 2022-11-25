namespace InitInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                FirstName = "Maharoz",
                LastName="Mugdho"
            };
            Console.WriteLine(person.FirstName+ " " + person.LastName);
            person.LastName = "Alam";
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   
}