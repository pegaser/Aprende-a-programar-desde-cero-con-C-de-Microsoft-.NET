using System;
using System.IO;

namespace ListingDriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine($" Drive {driveInfo.Name}");
                Console.WriteLine($" File type: {driveInfo.DriveType}");
                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine($" Volume label: {driveInfo.VolumeLabel}");
                    Console.WriteLine($" File system: { 0}", driveInfo.DriveFormat);
                    Console.WriteLine($" Available space to current user:{ driveInfo.AvailableFreeSpace} bytes");
                    Console.WriteLine($" Total available space: {driveInfo.TotalFreeSpace} bytes") ;
                    Console.WriteLine($" Total size of drive: {driveInfo.TotalSize} bytes ");
                }
                Console.ReadKey();
            }
        }
    }
}
