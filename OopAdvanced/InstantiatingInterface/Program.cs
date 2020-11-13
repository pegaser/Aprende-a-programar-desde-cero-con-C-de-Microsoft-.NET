namespace InstantiatingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
        }
        void MoveAnimimal(IAnimal animal)
        {
            animal.Move();
        }
    }
    interface IAnimal
    {
        void Move();
    }
    class Dog : IAnimal
    {
        public void Move() { }
        public void Bark() { }
    }
}
