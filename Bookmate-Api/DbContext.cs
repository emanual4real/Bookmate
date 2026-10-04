using Bookmate_Api.Models;
using Microsoft.EntityFrameworkCore;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Series> Series { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}