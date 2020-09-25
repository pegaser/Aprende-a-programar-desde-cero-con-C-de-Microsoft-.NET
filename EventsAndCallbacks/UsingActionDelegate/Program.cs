using System;

namespace UsingActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(3, 4);
            Console.Read();
        }
    }
}
