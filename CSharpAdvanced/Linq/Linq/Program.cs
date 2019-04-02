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
            Book book = books.Single(b => b.Title == "ASP.NET MVC");

            // LINQ Query operators
            IEnumerable<Book> cheaperBooks =  from b in books
                                                where b.Price < 10
                                                orderby b.Title
                                                select b;

            // Extension LINQ methods
            IEnumerable<string> cheapBooks = books
                                                .Where(b => b.Price < 10)
                                                .OrderBy(b => b.Title)
                                                .Select(b => b.Title);

            Console.ReadLine();
        }
    }
}
