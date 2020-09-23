using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingCancellationToken
{
    class Program
    {
        static void Main(string[] args)
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
            }, token);
            Console.WriteLine("Presiona ENTER para cancelar la tarea.");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Presiona ENTER para terminar la aplicación.");
            Console.ReadLine();
        }
    }
}
