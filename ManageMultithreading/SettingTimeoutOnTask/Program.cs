using System;
using System.Threading;
using System.Threading.Tasks;

namespace SettingTimeoutOnTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });
            int index = Task.WaitAny(new[] { longRunning }, 1000);
            if (index == -1)
                Console.WriteLine("Tiempo de espera agotado.");
            Console.Read();
        }
    }
}
