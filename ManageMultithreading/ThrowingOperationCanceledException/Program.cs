using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThrowingOperationCanceledException
{
    class Program
    {
        static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token).ContinueWith((t) =>
            {
                t.Exception.Handle((e) => true);
                Console.WriteLine("Has cancelado la tarea.");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Presiona ENTER para cancelar la tarea.");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Presiona ENTER para terminar la aplicación.");
            Console.ReadLine();
        }
    }
}
