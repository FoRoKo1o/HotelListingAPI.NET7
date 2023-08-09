using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
