
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            Func<Book, bool> x = b => b.Price < 10;
            Predicate<Book> y = b => b.Price < 10;

            var cheapBooks = books.FindAll(y);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadLine();

        }
    }
}
