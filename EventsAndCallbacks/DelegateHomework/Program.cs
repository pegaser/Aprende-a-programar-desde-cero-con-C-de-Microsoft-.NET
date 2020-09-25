using System;

namespace DelegateHomework
{
    class Program
    {
        delegate void MathCalculation(float value1, float value2);

        public static void AddNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public static void SubtractNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 - value2);
        }
        public static void MultiplyNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 * value2);
        }
        public static void DivideNumbers(float value1, float value2)
        {
            Console.WriteLine(value1 / value2);
        }

        static void Main(string[] args)
        {
            MathCalculation calculateAll = AddNumbers;
            calculateAll += SubtractNumbers;
            calculateAll += MultiplyNumbers;
            calculateAll += DivideNumbers;

            calculateAll(4, 2);
            Console.Read();
        }
    }
}
