using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.DTO.User
{
    public class LoginDto
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
