using System;
using System.Globalization;

namespace FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Sergio", "Pérez");
            Console.WriteLine(p.ToString(null));
            Console.ReadKey();

            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new System.Globalization.CultureInfo("en-US")));// Displays $1,234.56
            Console.ReadKey();

            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("es-MX");
            Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013
            Console.WriteLine(d.ToString("M", provider)); // Displays April 22
            Console.ReadKey();

            int a = 1;
            int b = 2;
            string result = $"a: {a}, b: {b}";
            Console.WriteLine(result); // Displays ‘a: 1, b: 2’
            Console.ReadKey();
        }
    }
    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format) || format == "G") 
                format = "FL";

            format = format.Trim().ToUpperInvariant();
            switch (format)
            {
                case "FL":
                    return FirstName + " " + LastName;
                case "LF":
                    return LastName + " " + FirstName;
                case "FSL":
                    return FirstName + ", " + LastName;
                case "LSF":
                    return LastName + ", " + FirstName;
                default:
                    throw new FormatException(String.Format("The ‘{ 0 }’ format string is not supported.", format));
            }
        }
    }
}
