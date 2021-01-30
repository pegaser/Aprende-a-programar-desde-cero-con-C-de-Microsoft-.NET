using System;
using System.Globalization;

namespace FormattingStringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature tem = new Temperature(100.70m);
            Console.WriteLine(tem.ToString("G", CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine(tem.ToString("F", CultureInfo.CreateSpecificCulture("es-MX")));
            Console.WriteLine(tem.ToString("K", CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(tem.ToString("F"));
            Console.WriteLine(tem.ToString());
            Console.Read();
        }
    }
}
