using System.Collections.Generic;

namespace CardsProfileApp.API.Models
{
    public class PSVideoGallery
    {
        public int Id { get; set; }
        public string DisplayValue { get; set; }
        public string PreviewUrl { get; set; }  
        public string Description { get; set; }
        public List<PSVideoGalleryLinks> DownloadLinks { get; set; }
        public int PSProfileId { get; set; }
    }
}