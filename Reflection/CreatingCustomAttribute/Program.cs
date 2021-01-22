using System;

namespace CreatingCustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class AuthorAttribute : System.Attribute
    {
        private string name;
        public double version;

        public AuthorAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }
    }

    [Author("Sergio Pérez", version = 1.1)]
    class SampleClass
    {
        // Aqui código de Sergio Pérez...  
    }
}
