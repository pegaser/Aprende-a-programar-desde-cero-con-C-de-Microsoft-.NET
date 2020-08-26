using System;
using System.Collections.Concurrent;

namespace UsingConcurrentQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            
            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine($"Dequeued: {result}");

            Console.Read();
        }
    }
}
