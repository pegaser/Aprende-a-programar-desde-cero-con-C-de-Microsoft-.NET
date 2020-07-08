using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public sealed class Book : Publication
    {
        public string ISBN { get; }
        public string Author { get; }
        public Decimal Price { get; private set; }
        public string Currency { get; private set; }

        public Book(string title, string author, string publisher) : this(title, String.Empty, author, publisher) { }
        public Book(string title, string isbn, string author, string publisher) : base(title, publisher, PublicationType.Book)
        {
            if(!String.IsNullOrEmpty(isbn))
            {
                if (!(isbn.Length == 10 | isbn.Length == 13))
                    throw new ArgumentException("El ISBN debe ser de 10 a 13 caracteres");

                ulong nISBN = 0;
                if (!UInt64.TryParse(isbn, out nISBN))
                    throw new ArgumentException("El ISBN consiste de caracteres numérico solamente");
            }
            ISBN = isbn;
            Author = author;
        }

        public Decimal SetPrice(Decimal price, string currency)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException("El precio no puede ser negativo.");
            Decimal oldValue = Price;
            Price = price;

            if (currency.Length != 3)
                throw new ArithmeticException("El simbolo de moneda ISO es de 3 caracteres.");
            Currency = currency;

            return oldValue;
        }

        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

        public override string ToString()
        {
            return $"{(String.IsNullOrEmpty(Author) ? "" : Author + ", ")}{Title}";
        }

        public override bool Equals(object obj)
        {
            Book book = obj as Book;
            if (book == null)
                return false;
            else
                return ISBN == book.ISBN;
        }
    }
}
