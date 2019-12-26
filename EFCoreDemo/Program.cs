using System.Collections.Generic;
namespace EFCoreDemo
{
    class Program
    {
        static void Main2(string[] args)
        {
            using (var context = new EFCoreDemoContext())
            {
                var author = new Author
                {
                    FirstName = "William",
                    LastName = "Shakespeare",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            using (var context = new EFCoreDemoContext())
            {
                foreach (var book in context.Books)
                {
                    System.Console.WriteLine(book.Title);
                }
                System.Console.ReadLine();
            }
        }
    }
}