using System;
using System.Threading;

namespace ThreadClassExample
{
    class CreatingThreadProgram
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hilo principal: Trabajando...");
                Thread.Sleep(0);
            }
            Console.Read();
        }
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Proceso de hilo: {i}");
                Thread.Sleep(0);
            }
        }
    }
}
