using System;
namespace BookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Minia Public Library", "Minia, Egypt");

            library.AddBook("Clean Code", "Robert C. Martin", "Prentice Hall", true);
            library.AddBook("The Pragmatic Programmer", "Andrew Hunt", "Addison-Wesley", true);
            library.AddBook("Design Patterns", "Gang of Four", "Addison-Wesley", true);

            Console.WriteLine("Initial collection:");
            library.DisplayCollection();
            Console.WriteLine();

            library.CheckOutBook("Clean Code");
            Console.WriteLine("Checked out: Clean Code");

            library.CheckOutBook("Clean Code");

            Console.WriteLine();

            library.ReturnBook("Clean Code");
            Console.WriteLine("Returned: Clean Code");

            Console.WriteLine();
            Console.WriteLine("Final collection:");
            library.DisplayCollection();
        }
    }
}