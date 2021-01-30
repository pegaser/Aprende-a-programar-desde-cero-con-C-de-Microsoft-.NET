using System;
using System.Text.RegularExpressions;

namespace SearchingForAndEnumStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p'); // returns 6
            int lastIndexOfm = value.LastIndexOf('m'); // returns 5
            Console.WriteLine($"IndexOf p = {indexOfp}");
            Console.WriteLine($"LastIndexOf m = {lastIndexOfm}");
            Console.ReadKey();

            value = "< mycustominput >";
            if (value.StartsWith("<")) 
            {
                Console.WriteLine($"La cadena '{value}' inicia con '<'");
            }
            if (value.EndsWith(">")) 
            {
                Console.WriteLine($"La cadena '{value}' inicia con '<'");
            }
            Console.ReadKey();

            value = "My Sample Value";
            string subString = value.Substring(3, 6); // Returns ‘Sample’
            Console.WriteLine($"SubString(3,6) = '{subString}'");
            Console.ReadKey();

            string pattern = "(Ms.? |Mr.? | Miss | Mrs.?)";
            string[] names = {"Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
            Console.ReadKey();

            value = "My Custom Value";
            foreach (char c in value)
                Console.WriteLine(c);
            Console.ReadKey();

            foreach (string word in "My sentence separated by spaces".Split(' ')) 
            {
                Console.WriteLine(word);
                
            }
            Console.ReadKey();
        }
    }
}
