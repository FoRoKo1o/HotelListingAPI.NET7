using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
