using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("La tempestad", "0123456789", "Shakespare, William", "Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 18));
            ShowPublicationInfo(book);

            Book book2 = new Book("La tempestad", "Classic Press", "Shakespare, William");
            Console.WriteLine($"{book.Title} y {book2.Title} son la misma publicación: {((Publication)book).Equals(book2)}");
            Console.Read();

        }
        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title}, {(pubDate == "NPA" ? "No se ha publicado aún." : "Publicado el " + pubDate)} by {pub.Publisher}");
        }
    }
}
