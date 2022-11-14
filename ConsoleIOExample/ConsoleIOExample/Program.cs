using System;
using System.IO;

namespace ConsoleIOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Favor de ejecutar el programa de la siguiente manera: ConsoleIOExample entrada.txt salida.txt");
                return;
            }

            try
            {
                string inputFile;
                while (!File.Exists(Path.Combine(Environment.CurrentDirectory, args[1])))
                {
                    Console.WriteLine("Favor de proporcionar la ruta del archivo de entrada");
                    inputFile = Console.ReadLine();
                    return;
                }
                // Intentamos abrir el archivo de salida para escribir
                using (var writer = new StreamWriter(args[1]))
                {
                    using (var reader = new StreamReader(args[0]))
                    {
                        // Redireccionamos salida estandar a archivo.
                        Console.SetOut(writer);
                        // Redireccionamos entrada estandar a archivo.
                        Console.SetIn(reader);
                        string line;
                        while ((line = Console.ReadLine()) != null)
                        {
                            string newLine = line.Replace(" ", "\t");
                            Console.WriteLine(newLine);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                return;
            }

            // Restauramos la salida a pantalla
            var standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Console.WriteLine($"Se han sustituido espacios por tabuladores exitosamente en {args[0]}.");
            return;
        }
    }
}
