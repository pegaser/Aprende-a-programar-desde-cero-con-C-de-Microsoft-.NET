using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UsingAsyncAwait
{
    class Program
    {
        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.Read();
        }
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
