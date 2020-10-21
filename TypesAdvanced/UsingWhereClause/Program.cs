namespace UsingWhereClause
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<XClass> myClass = new GenericClass<XClass>();
            XClass xClass = myClass.MyProperty;
        }
    }

    class XClass
    {
    }

    class GenericClass<T> where T : class, new()
    {
        public GenericClass()
        {
            MyProperty = new T();
        }
        public T MyProperty { get; set; }
        
        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
        }
    }

}
