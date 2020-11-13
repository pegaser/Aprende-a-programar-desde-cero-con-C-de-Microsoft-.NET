namespace CreatingAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.AbstractMethod();
            derived.MethodWithImplementation();
        }
    }
    abstract class Base
    {
        public virtual void MethodWithImplementation() 
        {
            /*Método con implementación*/
        }
        public abstract void AbstractMethod();
    }
    class Derived : Base
    {
        public override void AbstractMethod() { }
    }
}
