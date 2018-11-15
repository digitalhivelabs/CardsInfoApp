using System.Collections.Generic;

namespace CardsProfileApp.API.Models
{
    public class PSVideoGalleryLinks
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public List<PSVideoGalleryUrl> Urls { get; set; }
    }
}