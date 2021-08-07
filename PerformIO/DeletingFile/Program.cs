using System;
using System.IO;

namespace DeletingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\test.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            string destPath = @"c:\temp\destTest.txt";
            File.CreateText(path).Close();
            FileInfo fileInfo3 = new FileInfo(path);
            fileInfo3.CopyTo(destPath);


        }
    }
}
