using System;
using Microsoft.AspNetCore.Http;

namespace CardsProfileApp.API.DTOs
{
    public class PhotoForCreationDTO
    {
        public PhotoForCreationDTO() 
        {
            DateAdded = DateTime.Now;
        }

        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}