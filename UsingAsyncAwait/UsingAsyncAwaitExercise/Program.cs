using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UsingAsyncAwaitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sites = new List<string> { "http://www.microsoft.com", "http://www.google.com", "http://www.msn.com" };
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (string site in sites)
            {
                tasks.Add(DownloadContent(site));
            }
            int index = Task.WaitAny(tasks.ToArray());
            Task<string> taskCompleted = tasks.ToArray()[index];
            Console.WriteLine($"El sitio que respondió primero fue: {taskCompleted.Result} ");
            Console.Read();

        }
        public static async Task<string> DownloadContent(string site)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(site);
                return site;
            }
        }
    }
}
