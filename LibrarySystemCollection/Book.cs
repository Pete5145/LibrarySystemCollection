using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemCollection
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Availability { get; set; }

        public Book(string title, string author, string  isbn, string availability)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Availability = availability;
        }
    }
}
