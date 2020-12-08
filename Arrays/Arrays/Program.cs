using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de arreglos 1
            Console.ForegroundColor = ConsoleColor.Red;
            int[] array1 = new int[3];
            array1[0] = 100;
            array1[1] = 200;
            Console.WriteLine($"array1[0] = {array1[0]} y array1[1] = {array1[1]}");
            Console.ReadKey();

            //Declaración de arreglos 2
            Console.ForegroundColor = ConsoleColor.Green;
            int[] array2 = { 1, 3, 5, 7 };
            string[] array3 = { "Lun", "Mar", "Mie", "Jue", "Vie" };
            Console.WriteLine($"array2[2] = {array2[2]}, array2[4] = {array2[3]} y array3[1] = {array3[1]}");
            Console.ReadKey();

            //Declaracion de arreglos 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            double[] array4;
            array4 = new double[] { 1.1, 2.2, 3.3, 4.4 };
            Console.WriteLine($"array4[1] = {array4[1]} y array4[3] = {array4[3]}");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            int[][] arrayOfArrays = new int[2][];
            arrayOfArrays[0] = new int[] { 1 };
            arrayOfArrays[1] = new int[] { 2, 3, 4 };
            foreach (int[] item in arrayOfArrays)
            {
                foreach (int subItem in item)
                {
                    Console.WriteLine(subItem);
                }
            }
            Console.ReadKey();

            //Número de elementos
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"array1 tiene {array1.Length} elementos");
            Console.WriteLine($"array2 tiene {array2.Length} elementos");
            Console.WriteLine($"array3 tiene {array3.Length} elementos");
            Console.WriteLine($"array4 tiene {array4.Length} elementos");
            Console.WriteLine($"arrayOfArrays tiene {arrayOfArrays.Length} elementos");
            Console.ReadKey();

            //Número de dimensiones
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"array1 tiene {array1.Rank} dimensiones");
            Console.WriteLine($"array2 tiene {array2.Rank} dimensiones");
            Console.WriteLine($"array3 tiene {array3.Rank} dimensiones");
            Console.WriteLine($"array4 tiene {array4.Rank} dimensiones");
            Console.WriteLine($"arrayOfArrays tiene {arrayOfArrays.Rank} dimensiones");
            Console.ReadKey();

            //Arreglos de 2 dimensiones
            int[,] studentScores = new int[2, 2];
            studentScores[0, 0] = 10;
            studentScores[0, 1] = 9;
            studentScores[1, 0] = 8;
            studentScores[1, 1] = 10;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentScores[0, 0]}");
            Console.WriteLine($"El estudiante 1 del grupo 2 tiene una nota de {studentScores[1, 0]}");
            Console.WriteLine($"studentScores tiene {studentScores.Rank} dimensiones");
            Console.ReadKey();
        }
    }
}
