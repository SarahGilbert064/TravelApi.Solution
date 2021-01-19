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
            new Location { LocationId = 1, Name = "New Zealand", Rating = "5 Stars"},
            new Location { LocationId = 2, Name = "France", Rating = "4 Stars"},
            new Location { LocationId = 3, Name = "Somalia", Rating = "1 Star"},
            new Location { LocationId = 4, Name = "Antartica", Rating = "2 Stars"}
          );

        builder.Entity<Review>()
          .HasData(
            new Review { ReviewId = 1, Body = "Great hiking and backpacking! Beautiful country!", UserName = "Patrick", LocationId = 1},
            new Review { ReviewId = 2, Body = "So much history and art! People are kinda rude though.", UserName = "Sarah", LocationId = 2},
            new Review { ReviewId = 3, Body= "Very very cold but pretty", UserName = "Bobby", LocationId = 4}

          );  
      }
      

      public DbSet<Location> Locations { get; set; }
      public DbSet<Review> Reviews { get; set; } 
  }
}