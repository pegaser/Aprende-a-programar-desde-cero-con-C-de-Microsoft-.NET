using System;
using System.Threading.Tasks;

namespace UsingChildTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parent = Task.Run(() =>
            {
                int[] results = new int[3];

                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            Task finalTask = parent.ContinueWith(parentTask => 
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            finalTask.Wait();
            Console.Read();
        }
    }
}
