using System;

namespace UsingSealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived2 derived2 = new Derived2();
            Console.WriteLine(derived2.MyMethod());
            Console.Read();
        }
    }
    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }
    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
    class Derived2 : Derived
    {
        public override int MyMethod() { return 1;}
    }
}
