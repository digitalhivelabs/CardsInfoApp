using System.Collections.Generic;

namespace CardsProfileApp.API.DTOs.PSProfile
{
    public class PSVideoGalleryLinksForDetailsDTO
    {
        public string Source { get; set; }
        public List<PSVideoGalleryUrlForDetailsDTO> Urls { get; set; }        
    }
}
