using System;
using System.Threading;

namespace ThreadClassExample
{
    class ParameterizedThreadStart
    {
        public static void Main()
        {
            Thread t = new Thread(ThreadMethod);
            t.Start(5);
            t.Join();
            Console.Read();
        }
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"Hilo de proceso: {i}");
                Thread.Sleep(0);
            }
        }
    }
}
