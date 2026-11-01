using Microsoft.EntityFrameworkCore;

public class Turdean_Stefan_Lab2Context(DbContextOptions<Turdean_Stefan_Lab2Context> options) : DbContext(options)
{
    public DbSet<Turdean_Stefan_Lab2.Models.Book> Book { get; set; } = default!;
}
