using System;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            int counter = 0;
            
            Console.WriteLine("Presiona una tecla para iniciar el contador y vuelve a presionar otra tecla para cancelarlo.");
            Console.ReadLine();
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    counter++;
                    Console.Write($"{counter} ");
                    Thread.Sleep(500);
                }
            }, token);

            Console.ReadLine();
            cancellationTokenSource.Cancel();
        }

    }
}
