using System;
using System.Collections;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //PILAS
            string word;
            int counter;
            Stack greetingStack;

            //Usando PUSH y POP
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila.");
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.WriteLine($"Hay {counter} elementos en la pila.");
            Console.ReadKey();

            //Usando PEEK
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            counter = greetingStack.Count;
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                Console.WriteLine($"Siguiente palabra en la pila: {word}");

                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();

            //Usando CONTAINS y CLEAR
            Console.ForegroundColor = ConsoleColor.White;
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            if (greetingStack.Contains("días"))
            {
                greetingStack.Clear();
            }

            Console.WriteLine($"La pila greetingStack contiene {greetingStack.Count} elementos despues de ejecutar el método CLEAR.");
            Console.ReadKey();

            //COLAS
            Console.ForegroundColor = ConsoleColor.Cyan;
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("días");

            counter = greetingQueue.Count;
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola.");
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"El siguiente elemento en la cola es {word}");

                word = (string)greetingQueue.Dequeue();
                Console.WriteLine($"DEQUEUE: {word}");
            }
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola.");
            Console.ReadKey();


            //Usando CONTAINS y CLEAR
            Console.ForegroundColor = ConsoleColor.Gray;
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("días");
            if (greetingQueue.Contains("días"))
            {
                greetingQueue.Clear();
            }
            Console.WriteLine($"La cola greetingQueue contiene {greetingQueue.Count} elementos despues de ejecutar el método CLEAR.");
            Console.ReadKey();
        }
    }
}
