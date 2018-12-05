using System;
using System.ComponentModel.DataAnnotations;

namespace CardsProfileApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        public UserForRegisterDTO()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password must between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
    }
}