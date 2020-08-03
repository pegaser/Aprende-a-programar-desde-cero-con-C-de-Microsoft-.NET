using System;
using System.Threading.Tasks;

namespace UsingParallelBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Interrupiendo el bucle...");
                    loopState.Break();
                }
                return;
            });

            Console.WriteLine($"LowestBreakIteration: {result.LowestBreakIteration}");
            Console.WriteLine($"IsCompleted: {result.IsCompleted}");
            Console.Read();
        }
    }
}
