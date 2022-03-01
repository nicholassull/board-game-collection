using Microsoft.EntityFrameworkCore;
namespace BoardGameCollection.Models
{
  public class BoardGameCollectionContext : DbContext
  {
    public DbSet<BoardGame> BoardGames { get; set; }
    //public DbSet<Collection> Collections { get; set; }
    public BoardGameCollectionContext(DbContextOptions options) : base(options) { }
  }
}