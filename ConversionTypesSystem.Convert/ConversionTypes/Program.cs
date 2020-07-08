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
            // Convert an Int32 value to a Decimal (a widening conversion).
            int integerValue = 12534;
            decimal decimalValue = Convert.ToDecimal(integerValue);
            Console.WriteLine($"Convertiendo el valor {integerValue} del tipo {integerValue.GetType().Name} al valor {decimalValue:N2} del tipo {decimalValue.GetType().Name}");

            // Convert a Double value to an Int32 value (a narrowing conversion).
            double doubleValue = 16.32513e12;
            try
            {
                long longValue = Convert.ToInt64(doubleValue);
                Console.WriteLine($"Convertiendo el valor {doubleValue:E} del tipo {doubleValue.GetType().Name} al valor {longValue:N0} del tipo {longValue.GetType().Name}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"No se puede convertir tipo {doubleValue.GetType().Name} valor {doubleValue}");
            }

            SByte sbyteValue = -16;
            byte byteValue = 0;
            try
            {
                byteValue = Convert.ToByte(sbyteValue);
                Console.WriteLine($"Convertiendo el valor {sbyteValue} del tipo {sbyteValue.GetType().Name} al valor {byteValue:G} del tipo {byteValue.GetType().Name}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"No se puede convertir valor {sbyteValue} del tipo {sbyteValue.GetType().Name} al tipo {byteValue.GetType().Name}");
            }

            Console.Read();
        }
    }
}