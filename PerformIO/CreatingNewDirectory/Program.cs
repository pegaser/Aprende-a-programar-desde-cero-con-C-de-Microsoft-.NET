using System;
using System.IO;

namespace CreatingNewDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.CreateDirectory(@"C:\Temp\AprendeProgramarConCSharp\Directory");
            var directoryInfo = new DirectoryInfo(@"C:\Temp\AprendeProgramarConCSharp\DirectoryInfo");
            directoryInfo.Create();

            if (Directory.Exists(@"C:\Temp\AprendeProgramarConCSharp\Directory"))
            {
                Directory.Delete(@"C:\Temp\AprendeProgramarConCSharp\Directory");
            }
            var directoryInfo2 = new DirectoryInfo(@"C:\Temp\AprendeProgramarConCSharp\DirectoryInfo");
            if (directoryInfo2.Exists)
            {
                directoryInfo2.Delete();
            }


            Console.WriteLine("Terminé");
            Console.ReadKey();
        }
    }
}
