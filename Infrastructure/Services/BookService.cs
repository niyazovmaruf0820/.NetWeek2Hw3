using Infrastructure.Dapper;
using Dapper;
namespace Infrastructure.Services;
using Domain.Models;
public class BookService
{
    private DapperContext connect = new DapperContext();
    public List<Books> GetBooks()
    {
        return connect.Connection().Query<Books>("select b.Title,b.Description,b.DatePublished,b.PageQuantity,c.Name as CategoryName from Books as b join Categories as c on b.CategoryId = c.Id ").ToList(); 
    }
    public void AddBook(Books book)
    {
        connect.Connection().Execute("insert into Books(Title,Description,DatePublished,PageQuantity,CategoryId)values(@title,@description,@datepublished,@pagequantity,@categoryId)", book);
    }
    public void UpdateBook(Books book)
    {
        connect.Connection().Execute("update Books set Title = @title,Description = @description,DatePublished = @datepublished,PageQuantity = @pagequantity,CategoryId = @categoryid where Id = @id",book);
    }
    public void DeleteBook(int id)
    {
        connect.Connection().Execute("delete from Books where Id = @id",new {Id = id});
    }
    public Books GetBookById(int id)
    {
        return connect.Connection().Query<Books>("select * from Books where Id = @id",new{Id=id}).FirstOrDefault()!;
    }
    public Books GetBookByTitle(string title)
    {
        return connect.Connection().Query<Books>("select * from Books where Title = @title",new{title=title}).FirstOrDefault()!;
    }
    public List<Books> GetBooksByCategory(string category)
    {
        return connect.Connection().Query<Books>("select * from Books as b join Categories as c on b.CategoryId = c.Id where c.Name = @Name",new{Name=category}).ToList();
    }
    public List<Books> GetAuthorOfBookByHisId(int id)
    {
        return connect.Connection().Query<Books>("select a.FullName as AuthorName from BookAuthors as ba join Books as b on ba.BookId = b.Id join Authors as a on ba.AuthorId = a.Id where b.Id = @id",new{Id = id}).ToList()!;
    }
    public List<Books> GetBooksByHisAuthorsId(int id)
    {
        return connect.Connection().Query<Books>("select b.Title,b.Description,b.DatePublished,b.PageQuantity from BookAuthors as ba join Books as b on ba.BookId = b.Id join Authors as a on ba.AuthorId = a.Id where a.Id = @id",new {Id = id}).ToList();
    }
}
