using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> duplicateValue = delegate (int x)
            {
                return x * 2;
            };
            Console.WriteLine(duplicateValue(11));
            Console.ReadKey();

            Func<int, int> duplicateValueLambda = x => x * 2;
            Console.WriteLine(duplicateValueLambda(11));
            Console.ReadKey();
        }
    }
}
