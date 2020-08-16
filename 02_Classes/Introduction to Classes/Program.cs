using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // Instance method
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // var person = new Person();
            // person.Name = "John";
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
