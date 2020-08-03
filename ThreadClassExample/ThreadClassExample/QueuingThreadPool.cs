using System;
using System.Threading;

namespace ThreadClassExample
{
    class QueuingThreadPool
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Trabajando un hilo desde un ThreadPool");
            });
            Console.ReadLine();
        }
    }
}
