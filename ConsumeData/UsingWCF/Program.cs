using System;
using System.Threading.Tasks;

namespace UsingWCF
{
    class Program
    {
        static async Task Main(string[] args)
        {
            MyServiceReference.Service1Client client = new MyServiceReference.Service1Client();

            string returnString;
            returnString = await client.GetDataAsync(3);
            Console.WriteLine(returnString);
            Console.ReadKey();
        }
    }
}
