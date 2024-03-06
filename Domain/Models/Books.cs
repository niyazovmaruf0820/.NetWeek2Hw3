namespace Domain.Models;

public class Books
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DatePublished { get; set; }
    public int PageQuantity { get; set; }
    public int CategrotyId { get; set; }
    public string? CategoryName { get; set; }
    public string? AuthorName { get; set; }
}
