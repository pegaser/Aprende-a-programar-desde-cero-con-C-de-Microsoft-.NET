using System;
using System.Collections.Concurrent;

namespace UsingConcurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(42);
            
            int result;
            if (stack.TryPop(out result))
                Console.WriteLine($"Popped: {result}");

            stack.PushRange(new int[] { 1, 2, 3 });
            
            int[] values = new int[2];
            stack.TryPopRange(values);
            
            foreach (int i in values)
                Console.WriteLine(i);

            Console.Read();
        }
    }
}
