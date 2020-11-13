using System;
using System.IO;

namespace InterfacesExercise
{
    class MyFileReader : IDisposable
    {
        TextReader textReader = null;

        public MyFileReader(string path)
        {
            Console.WriteLine("Adquiriendo recursos administrados.");
            textReader = new StreamReader(path);
            Console.WriteLine("Adquiriendo recursos no administrados.");
        }

        void ReleaseManagedResources()
        {
            Console.WriteLine("Liberando recursos administrados.");
            if (textReader != null)
            {
                textReader.Dispose();
            }
        }

        void ReleaseUnmangedResources()
        {
            Console.WriteLine("Liberando recursos no administrados.");
        }

        public void ShowData()
        {
            if (textReader != null)
            {
                Console.WriteLine(textReader.ReadToEnd() + " /Algunos datos no administrados ");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose llamado desde el exterior");

            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Dispose llamado con " + disposing.ToString());
            if (disposing == true)
            {
                ReleaseManagedResources();
            }
            else
            {
            }

            ReleaseUnmangedResources();

        }

        ~MyFileReader()
        {
            Console.WriteLine("Finalizador llamado.");
            Dispose(false);
        }
    }
}
