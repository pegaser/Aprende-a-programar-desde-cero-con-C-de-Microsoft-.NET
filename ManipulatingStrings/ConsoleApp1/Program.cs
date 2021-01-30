using System;

namespace ChangingCharStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("A valor inicial");
            sb[0] = 'B';
            Console.WriteLine($"sb = '{sb}'");
            Console.Read();
        }
    }
}
