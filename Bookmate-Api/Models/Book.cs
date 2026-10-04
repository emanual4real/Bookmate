namespace Bookmate_Api.Models;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public IList<Author> Authors { get; set; } = [];
    public int PublicationYear { get; set; }
    public int SeriesId { get; set; }
}