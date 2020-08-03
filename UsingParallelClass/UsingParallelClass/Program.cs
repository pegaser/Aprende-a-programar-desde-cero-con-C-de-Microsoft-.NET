using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParallelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Iteracción {i} del FOR.");
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Iteracción {i} del FOREACH.");
            });
            Console.Read();
        }
    }
}
