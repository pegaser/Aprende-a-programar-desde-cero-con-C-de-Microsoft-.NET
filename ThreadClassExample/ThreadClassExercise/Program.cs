using System;
using System.Threading;

namespace ThreadClassExercise
{
    class Program
    {
        static bool stopped = false;
        
        public static void ThreadMethod()
        {
            int index = 0;
            while (!stopped || index == int.MaxValue)
            {
                index++;
                Console.WriteLine($"Veces que se ha ejecutado: {index}");
                Thread.Sleep(3000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            Console.WriteLine("Presione una tecla para parar el proceso");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
        
    }
}
