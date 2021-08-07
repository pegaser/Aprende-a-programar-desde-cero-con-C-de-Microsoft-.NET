using System;
using System.IO;

namespace MovingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Move(@"C:\source", @"c:\destination");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Source");
            directoryInfo.MoveTo(@"C:\destination");
        }
    }
}
