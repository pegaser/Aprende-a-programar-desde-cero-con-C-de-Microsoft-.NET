using System;
using System.Threading;

namespace ThreadClassExample
{
    class BackgroundThreadProgram
    {
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
            Console.Read();
        }
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hilo de proceso: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
