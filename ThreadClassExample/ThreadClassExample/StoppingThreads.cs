using System;
using System.Threading;

namespace ThreadClassExample
{
    class StoppingThreads
    {
        public static void Main()
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Corriendo...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
