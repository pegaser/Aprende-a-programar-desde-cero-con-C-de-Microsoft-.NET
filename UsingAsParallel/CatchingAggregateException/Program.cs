using System;
using System.Linq;

namespace CatchingAggregateException
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Hay {e.InnerExceptions.Count} excepciones.");
            }
            finally
            {
                Console.Read();
            }
        }
        public static bool IsEven(int i)
        {
            if (i % 10 == 0) 
                throw new ArgumentException($"{i}");

            return i % 2 == 0;
        }
    }
}
