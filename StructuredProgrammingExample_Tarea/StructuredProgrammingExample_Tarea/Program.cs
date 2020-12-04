using System;

namespace StructuredProgrammingExample_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            double firstData;
            double secondData;
            bool isExit = false;

            while (!isExit)
            {
                Console.Clear();
                Console.WriteLine("¡Bienvenido a tu calculadora!");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");
                operation = GetIntegerDataFromUser("Proporciona la operación que deseas ejecutar:");

                switch (operation)
                {
                    case 1:
                        //Suma
                        firstData = GetDoubleDataFromUser("Proporciona el primer operando, debe ser entero:");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo operando, debe ser entero:");
                        Console.WriteLine($"El resultado de {firstData} + {secondData} = {firstData + secondData}");
                        Console.ReadKey();
                        break;
                    case 2:
                        //Resta
                        firstData = GetDoubleDataFromUser("Proporciona el primer operando, debe ser entero:");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo operando, debe ser entero:");
                        Console.WriteLine($"El resultado de {firstData} - {secondData} = {firstData - secondData}");
                        Console.ReadKey();
                        break;
                    case 3:
                        //Salir
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no existe. Presione cuaquier tecla.");
                        Console.ReadKey();
                        break;
                }
            }
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

        private static double GetDoubleDataFromUser(string message)
        {
            string userData;
            double data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!double.TryParse(userData, out data))
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
