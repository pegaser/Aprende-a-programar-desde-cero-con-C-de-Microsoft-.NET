using System;
using System.Threading.Tasks;

namespace UsingGenericTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 22;
            });
            Console.WriteLine(t.Result); 
            Console.Read();
        }
    }
}
