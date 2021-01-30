using System;

namespace CreatingLargeNumberOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                s += "x";
            }
            Console.WriteLine($"Terminé con s = {s}");
            Console.Read();
        }
    }
}
