using HotelListingAPI.DTO.Hotel;
using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.DTO.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
