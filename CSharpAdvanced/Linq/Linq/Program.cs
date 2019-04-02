using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            IEnumerable<Book> cheapBooks = books.Where(b => b.Price < 10);

            foreach(Book book in cheapBooks)
            {
                Console.WriteLine($"{book.Title}: {book.Price}");
            }
            Console.ReadLine();
        }



    
    }
}
