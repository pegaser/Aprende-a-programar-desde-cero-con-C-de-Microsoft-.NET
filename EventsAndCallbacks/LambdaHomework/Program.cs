using System;

namespace LambdaHomework
{
    class Program
    {
        public delegate int GetRandomNumberDelegate();
        static void Main(string[] args)
        {
            GetRandomNumberDelegate getRandomNumber = GetRandomNumber;
            Console.WriteLine(getRandomNumber());
            Console.ReadKey();
        }
        static int GetRandomNumber()
        {
            return new Random().Next(1, 100);
        }
    }
}
