using System;

namespace UsingDelegatesWithLambda
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            //Calculate calc =
            //(x, y) =>
            //{
            //    Console.WriteLine("Adding numbers");
            //    return x + y;
            //};
            calc(3, 4);
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
            Console.Read();
        }
    }
}
