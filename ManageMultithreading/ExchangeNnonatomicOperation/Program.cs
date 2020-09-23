using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExchangeNnonatomicOperation
{
    class Program
    {
        static int value = 1;
        public static void Main()
        {
            Task t1 = Task.Run(() =>
            {
                //if (value == 1)
                //{
                //    Thread.Sleep(1000);
                //    value = 2;
                //}
                Thread.Sleep(1000);
                Interlocked.CompareExchange(ref value, 2, 1);

            });
            Task t2 = Task.Run(() =>
            {
                value = 3;
            });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
            Console.Read();
        }
    }
}
