using System.ComponentModel.DataAnnotations;

namespace CardsProfileApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        public string DisplayName { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password must between 4 and 8 characters")]
        public string Password { get; set; }
    }
}