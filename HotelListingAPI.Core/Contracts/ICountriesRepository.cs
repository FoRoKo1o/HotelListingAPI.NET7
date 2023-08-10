using HotelListingAPI.Data;

namespace HotelListingAPI.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
