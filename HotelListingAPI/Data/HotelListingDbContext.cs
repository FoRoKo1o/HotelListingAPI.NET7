using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext: DbContext 
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Insert examlpe data for testing purposes
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Poland",
                    ShortName = "PL",
                },
                new Country
                {
                    Id = 2,
                    Name = "Germany",
                    ShortName = "DE",
                },
                new Country
                {
                    Id = 3,
                    Name = "Slovakia",
                    ShortName = "SK",
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Novotel",
                    Address = "Warszawa",
                    CountryId = 1,
                    Rating = 4.5,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Riu Plaza",
                    Address = "Berlin",
                    CountryId = 2,
                    Rating = 4.7,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Apollo Hotel",
                    Address = "bratislava",
                    CountryId = 3,
                    Rating = 4.6,
                }
            );
        }
    }
}
