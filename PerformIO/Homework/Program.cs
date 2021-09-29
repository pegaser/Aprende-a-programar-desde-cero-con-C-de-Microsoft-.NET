using System;
using System.IO;
using System.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitarás un DRIVE
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            //Iterarás el arreglo drivesInfo para mostrar las opciones al usuario
            //Guardarás el datos proporcionado por el usuario

            //Validarás si el datos es correcto
            if (drivesInfo.Where(drive => drive.Name == driveSelected).Count() <= 0)
            //{
                ///...
                //return;
            //}

            //Solicitará el nombre del directorio
            string basePath = Path.Combine(driveSelected, directoryName);
            //Si existe, solo mencionas que ya existe
            //En caso contrario creas el directorio y avisas al usuario
            Directory.CreateDirectory(basePath);

            //Solicitas el nombre del archivo
            //Creas el path
            Path.Combine(basePath, fileName + ".txt");
            //Si existe el archivo le avisal al usuario, en caso contrario tambien

           //Solicitas una línea d etexto que se agregará al archivo
           /File.AppendAllText(filePath, text);
           
        }
    }
}
