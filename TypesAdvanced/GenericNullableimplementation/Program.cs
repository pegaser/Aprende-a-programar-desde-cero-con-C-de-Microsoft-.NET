using System;

namespace GenericNullableimplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> integerNulleable = new Nullable<int>(3);
            Console.WriteLine(integerNulleable.Value);

            Console.Read();
        }
    }
    struct Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;
        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }
        public bool HasValue { get { return this.hasValue; } }
        public T Value
        {
            get
            {
                if (!this.HasValue) throw new ArgumentException();
                return this.value;
            }
        }
        public T GetValueOrDefault()
        {
            return this.value;
        }
    }
}
