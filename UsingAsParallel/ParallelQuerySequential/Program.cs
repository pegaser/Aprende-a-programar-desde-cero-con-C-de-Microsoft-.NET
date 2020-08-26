using System;
using System.Linq;

namespace ParallelQuerySequential
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential();
            
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);

            Console.Read();
        }
    }
}
