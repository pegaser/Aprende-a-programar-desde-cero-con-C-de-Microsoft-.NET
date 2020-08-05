using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTaskExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() => Sleep(11000));
            Task Continuation1 = task1.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task.Result} segundos.");
            });

            Task<int> task2 = Task.Run(() => Sleep(7000));
            Task Continuation2 = task2.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task.Result} segundos");
            });

            Task<int> task3 = Task.Run(() => Sleep(4000));
            Task Continuation3 = task3.ContinueWith((task) =>
            {
                Console.WriteLine($"Terminé de dormir. Dormí por {task.Result} segundos");
            });

            Continuation1.Wait();
            Continuation2.Wait();
            Continuation3.Wait();
            Console.WriteLine("Adiós");
            Console.Read();
        }

        /// <summary>
        /// Método que duerme determinados milisegundos el hilo actual y regresa el número de segundos que dormirá.
        /// </summary>
        /// <param name="miliseconds">Númeor de milisegundos que se dormirá el hilo actual</param>
        /// <returns>Número de segundos que se durmió el hilo actual</returns>
        static int Sleep(int miliseconds)
        {
            Console.WriteLine($"Durmiendo {miliseconds / 1000} segundos...");
            Thread.Sleep(miliseconds);
            return miliseconds/1000;
        }
    }
}
