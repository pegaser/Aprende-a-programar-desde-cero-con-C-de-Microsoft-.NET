using System;

namespace ReferenceVsValuesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 7;
            Console.WriteLine($"Index antes de llamar Sum4: { index}");
            Console.WriteLine($"Sum4: {Sum4(index)}");
            Console.WriteLine($"Index después de llamar Sum4: {index}");
            Console.ReadLine();

            Person person = new Person();
            person.Name = "Sergio";
            person.Age = 40;

            Console.WriteLine($"Person Name: {person.Name}");
            ChangeName(person);
            Console.WriteLine($"Person Name: {person.Name}");
            Console.Read();
        }
        public static int Sum4(int number)
        {
            number = number + 4;
            return number;
        }
        public static void ChangeName(Person p)
        {
            p.Name = p.Name + " Change";
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
