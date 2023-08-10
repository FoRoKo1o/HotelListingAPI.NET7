using AutoMapper;
using HotelListingAPI.Contracts;
using HotelListingAPI.Data;

namespace HotelListingAPI.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly IMapper _mapper;
        public HotelRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._mapper = mapper;
        }
    }
}
