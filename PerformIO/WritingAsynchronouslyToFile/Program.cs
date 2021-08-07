using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WritingAsynchronouslyToFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ReadAsyncHttpRequest();
            Console.ReadKey();
        }

        public static async Task CreateAndWriteAsyncToFile()
        {
            using (FileStream stream = new FileStream(@"C:\temp\test.dat", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);
                await stream.WriteAsync(data, 0, data.Length);
            }
        }

        public static async Task ReadAsyncHttpRequest()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://www.microsoft.com");
            Console.WriteLine(result);
        }

        public async Task ExecuteMultipleRequestsInParallel()
        {
            HttpClient client = new HttpClient();
            Task microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("http://blogs.msdn.com/");
            await Task.WhenAll(microsoft, msdn, blogs);
        }

    }
}
