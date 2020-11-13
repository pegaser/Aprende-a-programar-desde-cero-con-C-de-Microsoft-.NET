using System;

namespace ImplementingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleImplementation exampleImplementation = new ExampleImplementation();
            Console.WriteLine(exampleImplementation.GetResult());
            Console.Read();
        }
    }
    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }
    }
    class ExampleImplementation : IExample
    {
        public string GetResult()
        {
            return "Result";
        }
        public int Value { get; set; }
        public event EventHandler CalculationPerformed;
        public event EventHandler ResultRetrieved;
        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }
    }
    class OtherImplementation : IExample
    {
        public int this[string index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler ResultRetrieved;

        public string GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
