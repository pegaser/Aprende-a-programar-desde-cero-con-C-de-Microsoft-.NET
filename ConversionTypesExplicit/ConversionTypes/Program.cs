using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = int.MaxValue + 20L;
            uint number2 = int.MaxValue - 1000;
            ulong number3 = int.MaxValue;

            int intNumber;

            try
            {
                intNumber = checked((int)number1);
                Console.WriteLine($"Despues de asignar un valor {number1.GetType().Name}, el valor decimal es {intNumber}.");
            }
            catch (OverflowException)
            {
                if (number1 > int.MaxValue)
                    Console.WriteLine($"Conversión fallida: {number1} excede {int.MaxValue}.");
                else
                    Console.WriteLine($"Conversión fallida: {number1} es menor {int.MinValue}.");
            }

            try
            {
                intNumber = checked((int)number2);
                Console.WriteLine($"Despues de asignar un valor {number2.GetType().Name}, el valor decimal es {intNumber}.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Conversión fallida: {number2} excede {int.MaxValue}.");
            }

            try
            {
                intNumber = checked((int)number3);
                Console.WriteLine($"Despues de asignar un valor {number3.GetType().Name}, el valor decimal es {intNumber}.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Conversión fallida: {number3} excede {int.MaxValue}.");
            }

            Console.Read();
        }
    }
}