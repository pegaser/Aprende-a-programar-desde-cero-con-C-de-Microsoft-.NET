using System;

namespace TypesAdvanced
{
    class Program
    {
        public enum Gender { Male, Female }
        enum Days : byte 
        { 
            Sat = 1, 
            Sun, 
            Mon, 
            Tue, 
            Wed, 
            Thu, 
            Fri 
        };
        [Flags]
        enum FlagDays
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }
        static void Main(string[] args)
        {
            Days day = Days.Sat;
            if ((byte)day == 1) 
            {
                Console.WriteLine("El día es Sábado");
            }


            FlagDays readingDays = FlagDays.Monday | FlagDays.Saturday;
            Console.Write(readingDays);
            Console.Read();
        }
    }
}
