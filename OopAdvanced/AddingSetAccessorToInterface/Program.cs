using System;

namespace AddingSetAccessorToInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWriteImplementation readAndWriteImplementation = new ReadAndWriteImplementation();
            readAndWriteImplementation.Value = 7;
            Console.WriteLine(readAndWriteImplementation.Value);
            Console.Read();
        }
    }
    interface IReadOnlyInterface : IComparable
    {
        int Value { get; }
    }
    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
