using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.DTO.Hotel
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(0, 5)]
        public double? Rating { get; set; } 
        public int CountryId { get; set; }

    }
}
