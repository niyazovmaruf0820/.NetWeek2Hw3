namespace WebAPI.Controllers;

using Domain.Models;
using Infrastructure.Services;

using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly BookService bookService;
    public BookController()
    {
        bookService = new BookService();
    }
    [HttpGet("get-books")]
    public List<Books> GetBooks()
    {
        return bookService.GetBooks();
    }
    [HttpGet("get-books-by-Id")]
    public Books GetBookById(int id)
    {
        return bookService.GetBookById(id);
    }
    [HttpGet("get-authors-by-bookId")]
    public List<Books> GetAuthorOfBookByHisId(int id)
    {
        return bookService.GetAuthorOfBookByHisId(id);
    }
    [HttpGet("get-book-by-title")]
    public Books GetBooksbyTitle(string title)
    {
        return bookService.GetBookByTitle(title);
    }
    [HttpGet("get-boooks-by-authorId")]
    public List<Books> GetBooksByHisAuthorsId(int id)
    {
        return bookService.GetBooksByHisAuthorsId(id);
    }
    [HttpPost("add-books")]
    public void AddBook(Books book)
    {
        bookService.AddBook(book);
    }
    [HttpPut("update-books")]
    public void UpdateBook(Books book)
    {
        bookService.UpdateBook(book);
    }
    [HttpDelete("delete-books")]
    public void DeleteBook(int id)
    {
        bookService.DeleteBook(id);
    }
}
