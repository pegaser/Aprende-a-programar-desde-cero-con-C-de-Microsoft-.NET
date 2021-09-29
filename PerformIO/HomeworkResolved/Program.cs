using System;
using System.IO;
using System.Linq;

namespace HomeworkResolved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona un DRIVE:");
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo item in drivesInfo)
            {
                Console.WriteLine(item.Name);
            }
            string driveSelected = Console.ReadLine();

            if (drivesInfo.Where(drive => drive.Name == driveSelected).Count() <= 0)
            {
                Console.WriteLine("Dato incorrecto");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Proporciona el nombre de la carpeta que se creará:");
            string directoryName = Console.ReadLine();
            string basePath = Path.Combine(driveSelected, directoryName);
            if (Directory.Exists(basePath))
            {
                Console.WriteLine("El directorio ya existe.");
            }
            else
            {
                Directory.CreateDirectory(basePath);
                Console.WriteLine($"Se creo el directorio: {basePath}");
            }

            Console.WriteLine("Proporciona el nombre del archivo TXT que se creará:");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(basePath, fileName + ".txt");
            if (File.Exists(filePath))
            {
                Console.WriteLine("El archivo ya existe. Se agregará la información a éste archivo.");
            }
            else
            {
                Console.WriteLine($"Se creará el archivo {filePath}");
            }

            Console.WriteLine("Proporciona un texto para gregar al archivo:");
            string text = Console.ReadLine();
            File.AppendAllText(filePath, text);
            Console.WriteLine($"Se agregó texto al archivo {filePath}");

            Console.ReadKey();

        }
    }
}
