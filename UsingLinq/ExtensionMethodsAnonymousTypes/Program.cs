using System;

namespace ExtensionMethodsAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine(x.Multiply(3));
            Console.ReadKey();

            var person = new
            {
                FirstName = "Sergio",
                LastName = "Pérez"
            };
            Console.WriteLine(person.GetType().Name);
            Console.ReadKey();
        }
    }
    public static class IntExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x * y;
        }
    }

}
