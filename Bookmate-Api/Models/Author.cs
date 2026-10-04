namespace Bookmate_Api.Models;

public class Author
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public IList<Book> Books { get; set; } = [];
}