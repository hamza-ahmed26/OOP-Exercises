using System;
using System.Collections.Generic;
namespace BookProject
{
    internal class Library
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        public List<Book> Books { get; private set; }

        public Library(string name, string location)
        {
            Name = name;
            Location = location;
            Books = new List<Book>();
        }

        public void AddBook(string title, string author, string publisher, bool availability)
        {
            Book newBook = new Book(title, author, publisher, availability);
            Books.Add(newBook);
        }

        public void CheckOutBook(string title)
        {
            Book book = Books.Find(b => b.Title == title);
            if (book == null)
            {
                Console.WriteLine($"Book '{title}' not found.");
                return;
            }
            book.CheckOut();
        }

        public void ReturnBook(string title)
        {
            Book book = Books.Find(b => b.Title == title);
            if (book == null)
            {
                Console.WriteLine($"Book '{title}' not found.");
                return;
            }
            book.Return();
        }

        public void DisplayCollection()
        {
            Console.WriteLine($"--- {Name} Library Collection ({Location}) ---");
            foreach (var book in Books)
            {
                string status = book.Availability ? "Available" : "Checked Out";
                Console.WriteLine($"'{book.Title}' by {book.Author} ({book.Publisher}) - {status}");

                if (book.CheckOutDate.HasValue)
                    Console.WriteLine($"   Checked out on: {book.CheckOutDate}");
                if (book.ReturnDate.HasValue)
                    Console.WriteLine($"   Returned on: {book.ReturnDate}");
            }
        }
    }
}