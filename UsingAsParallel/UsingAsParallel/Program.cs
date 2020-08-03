using System;
using System.Linq;

namespace UsingAsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
            
            foreach(int i in parallelResult)
                Console.WriteLine(i);
            
            Console.Read();
        }
    }
}
