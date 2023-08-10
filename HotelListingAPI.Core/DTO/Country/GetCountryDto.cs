using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.DTO.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }
}
