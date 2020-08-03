using System;
using System.Threading;

namespace ThreadClassExample
{
    class UsingThreadLocal
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });
        
        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine($"Hilo A: {x}");
                }
             }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine($"Hilo B: {x}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
