using System;

namespace StructuredProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            int firstData;
            int secondData;

            Console.WriteLine("¡Bienvenido a tu calculadora!");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            operation = GetIntegerDataFromUser("Proporciona la operación que deseas ejecutar:");

            switch (operation)
            {
                case 1:
                    //Suma
                    firstData = GetIntegerDataFromUser("Proporciona el primer operando, debe ser entero:");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operando, debe ser entero:");
                    Console.WriteLine($"El resultado de {firstData} + {secondData} = {firstData + secondData}");
                    break;
                case 2:
                    //Resta
                    firstData = GetIntegerDataFromUser("Proporciona el primer operando, debe ser entero:");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operando, debe ser entero:");
                    Console.WriteLine($"El resultado de {firstData} - {secondData} = {firstData - secondData}");
                    break;
                default:
                    Console.WriteLine("La opcion seleccionada no existe.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.Read();
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que proporcionaste no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }
    }
}
