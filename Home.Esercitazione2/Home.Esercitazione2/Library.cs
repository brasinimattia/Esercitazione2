using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Esercitazione2
{
    public class Library
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string OpeningHour { get; set; }
        public string ClosingHour { get; set; }

        private List<Book> Books;

        public Library(string name, string adress, string openinghour, string closinghour)
        {
            Name = name;
            Adress = adress;
            OpeningHour = openinghour;
            ClosingHour = closinghour;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book != null)
                Books.Add(book);

        }


        public int BooksNumber()
        {
            return Books.Count;
        }

        public Book SearchByTitle(string title)
        {
            foreach (Book l in Books)
            {
                if (l.Title == title)
                    return l;
            }
            return null;
        }


        public List<Book> SearchByAuthor(string author)
        {
            List<Book> result = new List<Book>();
            foreach (Book l in Books)
            {
                if (l.Author == author)
                    result.Add(l);
            }
            return result;
        }

    }
}
