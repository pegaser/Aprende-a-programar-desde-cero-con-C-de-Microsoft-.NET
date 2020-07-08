using SampleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleClass = new SampleClass();
            sampleClass.FirstName = "Sergio";
            sampleClass.SecondName = "Alejandro";
            Console.WriteLine(sampleClass.GetFullName());
            Console.ReadKey();

            sampleClass = new SampleClass();
            Console.WriteLine(sampleClass.GetFullName());
            Console.ReadKey();

            sampleClass = new SampleClass("Maria", "José");
            Console.WriteLine(sampleClass.GetFullName());
            Console.ReadKey();
        }
    }

    public class SampleClass
    {
        private string _secondName;

        public string FirstName { get; set; }
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
            }
        }
        public SampleClass()
        {
            FirstName = "Sin nombre";
        }
        public SampleClass(string firstName, string secondName)
        {
            FirstName = firstName;
            _secondName = secondName;
        }
        public string GetFullName()
        {
            F f = new F();
            f.value 
            return $"{FirstName} {_secondName}";
        }
        
        ~SampleClass()
        {
            Console.WriteLine("El finalizador se está ejecutando...");
        }
    }
}
