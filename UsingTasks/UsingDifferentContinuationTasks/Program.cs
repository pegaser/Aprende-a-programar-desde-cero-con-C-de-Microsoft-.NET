using System;
using System.Threading.Tasks;

namespace UsingDifferentContinuationTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 22;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("CANCELADO");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("FALLADO");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("COMPLETADO");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            Console.Read();
        }
    }
}
