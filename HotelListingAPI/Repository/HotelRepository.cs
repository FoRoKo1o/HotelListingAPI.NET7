using HotelListingAPI.Contracts;
using HotelListingAPI.Data;

namespace HotelListingAPI.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
