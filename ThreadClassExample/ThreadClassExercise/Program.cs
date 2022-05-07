using System;
using System.Threading;

namespace ThreadClassExercise
{
    class Program
    {
        static bool stopped = false;
        static bool maxIndex = false;
        public static void ThreadMethod()
        {
            int index = 0;
            while (!stopped || index == 2)
            {
                index++;
                Console.WriteLine($"Veces que se ha ejecutado: {index}");
                Thread.Sleep(3000);
                if (index >= 2)
                    maxIndex = true;
            }
        }

        static void Main(string[] args)
        {
            
            try
            {
                Thread t = new Thread(new ThreadStart(ThreadMethod));
                t.Start();
                Console.WriteLine("Presione una tecla para parar el proceso");
                Console.ReadKey();
                stopped = true;
                t.Join();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Termino hilo por un index máximo");
            }
            finally
            {
                
            }
        }
        
    }
}
