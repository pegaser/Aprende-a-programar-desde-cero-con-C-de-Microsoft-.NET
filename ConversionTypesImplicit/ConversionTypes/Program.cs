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
            byte byteValue = 16;
            short shortValue = -1024;
            int intValue = -1034000;
            long longValue = 1152921504606846976;

            decimal decimalValue;

            decimalValue = byteValue;
            Console.WriteLine($"Despues de asignar un valor {byteValue.GetType().Name}, el valor decimal es {decimalValue}.");

            decimalValue = shortValue;
            Console.WriteLine($"Despues de asignar un valor {shortValue.GetType().Name}, el valor decimal es {decimalValue}.");

            decimalValue = intValue;
            Console.WriteLine($"Despues de asignar un valor {intValue.GetType().Name}, el valor decimal es {decimalValue}.");

            decimalValue = longValue;
            Console.WriteLine($"Despues de asignar un valor {longValue.GetType().Name}, el valor decimal es {decimalValue}.");

            Console.Read();
        }
    }
}