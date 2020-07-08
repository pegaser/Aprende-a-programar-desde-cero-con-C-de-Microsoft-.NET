using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public enum PublicationType {  Misc, Book, Magazine, Article };

    public abstract class Publication
    {
        private bool published = false;
        private DateTime datePublished;
        private int totalPages;

        public string Publisher { get; }
        public string Title { get; }
        public PublicationType Type { get; }
        public string CopyrightName { get; private set; }
        public int CopyrightDate { get; private set; }
        public int Pages
        {
            get { return totalPages; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("El numero de paginas no puede ser cero o negativo");
                totalPages = value;
            }
        }

        public Publication(string title, string publisher, PublicationType type)
        {
            if(String.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("El editor es requerido.");
            }
            Publisher = publisher;

            if(String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("El título es requerido.");
            }
            Title = title;

            Type = type;
        }

        public string GetPublicationDate()
        {
            if (!published)
                return "NPA";
            else
                return datePublished.ToString("d");
        }

        public void Publish(DateTime datePublished)
        {
            published = true;
            this.datePublished = datePublished;
        }

        public void Copyright(string copyrightName, int copyrightDate)
        {
            if (String.IsNullOrWhiteSpace(copyrightName))
                throw new ArgumentException("El nombre del copyright es requerido");
            CopyrightName = copyrightName;

            int currentYear = DateTime.Now.Year;
            if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
                throw new ArgumentOutOfRangeException($"El año de copyright debería estar entre {currentYear - 10 } y {currentYear + 1}");
            CopyrightDate = copyrightDate;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
