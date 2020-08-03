using System;
using System.Threading.Tasks;

namespace UsingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100000; x++)
                {
                    Console.Write('*');
                }
            });
            t.Wait();
        }
    }
}
