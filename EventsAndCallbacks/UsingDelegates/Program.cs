using System;

namespace UsingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcultator calculator = new Calcultator();
            calculator.UseDelegate();
            Console.Read();
        }
    }

    class Calcultator
    {
        public delegate int Calculate(int x, int y);
        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }

        public void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
