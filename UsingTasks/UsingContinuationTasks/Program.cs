using System;
using System.Threading.Tasks;

namespace UsingContinuationTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 11;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);
            Console.Read();
        }
    }
}
