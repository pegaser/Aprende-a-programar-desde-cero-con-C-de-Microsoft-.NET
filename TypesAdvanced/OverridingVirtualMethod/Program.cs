using System;

namespace OverridingVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            Console.WriteLine(derived.MyMethod());
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
        public override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }
}
