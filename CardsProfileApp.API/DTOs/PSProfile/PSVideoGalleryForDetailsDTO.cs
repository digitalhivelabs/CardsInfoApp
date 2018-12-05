using System.Collections.Generic;

namespace CardsProfileApp.API.DTOs.PSProfile
{
    public class PSVideoGalleryForDetailsDTO
    {
        public string DisplayValue { get; set; }
        public string PreviewUrl { get; set; }  
        public string Description { get; set; }
        public List<PSVideoGalleryLinksForDetailsDTO> DownloadLinks { get; set; }
    }
}

