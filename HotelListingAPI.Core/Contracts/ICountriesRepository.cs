using HotelListingAPI.Data;
using HotelListingAPI.DTO.Country;

namespace HotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
