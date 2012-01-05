using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task06;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a test class that creates a library, adds few books to it and displays them.
            //Find all books by Nakov, delete them and print again the library.

            Book book1 = new Book("Encarta Encyclopedia", "Tom Jones", "Izdanie Trud", "1989", "sfrsdfr9342343");
            Book book2 = new Book("Raznovidnosti na ruskiq ribolov", "James Brown", "Prosveta", "1983", "sfrsf2342343");
            Book book3 = new Book("Introduction Programming with C#", "Svetlin Nakov", "Prosveta", "2011", "sfrsf2342343");
            Book book4 = new Book("Introduction Programming with Java", "Svetlin Nakov", "Prosveta", "1985", "sfrsf2342343");

            List<Book> books = new List<Book> { book1, book2, book3, book4 };

            Library library = new Library(books);
            library.Name = "My cool new library";
            //view books in newly created library
            library.ViewAllBooks();

            List<Book> NakovBooks = library.GetBooksByAuthor("Svetlin Nakov");
            //see how many Nakov books are there now
            Console.WriteLine("There are {0} Nakov's books in the library", NakovBooks.Count);

            foreach (Book NakovBook in NakovBooks)
            {
                library.DeleteBook(NakovBook);
            }
            //view library after deleting Nakov's Books
            library.ViewAllBooks();
            //see how many Nakov books are there now
            NakovBooks = library.GetBooksByAuthor("Svetlin Nakov");
            Console.WriteLine("Now there are {0} Nakov's books in the library", NakovBooks.Count);
            
        }
    }
}
