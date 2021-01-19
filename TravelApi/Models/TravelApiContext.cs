using Microsoft.EntityFrameworkCore;


namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext>options)
      : base(options)
      {
      }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // optionsBuilder.UseLazyLoadingProxies();
    }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Location>()
          .HasData(
            new Location { LocationId = 1, Name = "New Zealand", Rating = "5 Stars", Pros = "Great for outdoor lovers!", Cons = "Very Expensive"},
            new Location { LocationId = 2, Name = "France", Rating = "4 Stars", Pros = "Bread", Cons = "Rudeness"},
            new Location { LocationId = 3, Name = "Somalia", Rating = "1 Star", Pros = "Very Cheap", Cons ="Might Get Kidnapped"},
            new Location { LocationId = 4, Name = "Antartica", Rating = "2 Stars", Pros ="Snow Angels", Cons = "Endless Winter"}
          );
      }
      

      public DbSet<Location> Locations { get; set; }
      public DbSet<Review> Reviews { get; set; } 
  }
}