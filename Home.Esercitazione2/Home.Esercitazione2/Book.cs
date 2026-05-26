using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Esercitazione2
{
    public class Book
    {

        public string Author { get; set; }

        public string Title { get; set; }

        public int PublicationYear { get; set; }

        public string Publisher { get; set; }

        public int NumberOfPages { get; set; }


        public Book(string author, string title, int publicationYear, string publisher, int numberOfPages)
        {
            Author = author;
            Title = title;
            PublicationYear = publicationYear;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return $"Title: '{Title}', Author: {Author}, Year: {PublicationYear}, Publisher: {Publisher}, Pages: {NumberOfPages}";
        }

        public string ReadingTime()
        {
            if (NumberOfPages < 100)
                return "1h";
            if (NumberOfPages >= 100 && NumberOfPages <= 200)
                return "2h";

            return ">2h";
        }
    }
}
