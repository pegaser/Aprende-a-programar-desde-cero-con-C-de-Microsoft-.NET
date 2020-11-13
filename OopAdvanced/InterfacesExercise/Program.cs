using System;
using System.IO;

namespace InterfacesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileReader myFileReader = null;

            myFileReader = new MyFileReader(@"Files\test.txt");
            myFileReader.ShowData();
            
            Console.Read();
        }
    }
}
