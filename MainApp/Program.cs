using Domain.Models;
using Infrastructure.Services;

BookService bookService = new BookService();
// foreach (var item in bookService.GetBooks())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Title);
//     System.Console.WriteLine("------------------------------------");
// }


// foreach (var item in bookService.GetBooksByHisAuthorsId(6))
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Title);
//     System.Console.WriteLine("---------------------------");
// }

Books book = new Books();
book.Title = "jflksdjfl;a";
book.Description = "kjdafl;kjdsf;lkja;slkdjf;lkadsjf;lkas";
book.DatePublished = DateTime.UtcNow;
book.PageQuantity = 300;
book.CategrotyId = 3;
bookService.AddBook(book);