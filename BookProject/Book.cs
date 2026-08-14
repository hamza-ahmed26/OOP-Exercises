using System;
namespace BookProject
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public bool Availability { get; private set; }
        public DateTime? CheckOutDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }

        public Book(string title, string author, string publisher, bool availability)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Availability = availability;
        }

        public void CheckOut()
        {
            if (!Availability)
            {
                Console.WriteLine($"'{Title}' is already checked out.");
                return;
            }

            Availability = false;
            CheckOutDate = DateTime.Now;
        }

        public void Return()
        {
            if (Availability)
            {
                Console.WriteLine($"'{Title}' is not checked out.");
                return;
            }

            Availability = true;
            ReturnDate = DateTime.Now;
        }
    }
}