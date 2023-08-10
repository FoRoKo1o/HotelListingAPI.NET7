using HotelListingAPI.DTO;

namespace HotelListingAPI.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<PagedResult<TResult>> GetAllAsync<TResult>(QuerryParameters querryParameters);
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
