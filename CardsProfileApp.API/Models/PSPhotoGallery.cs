using System.Collections.Generic;

namespace CardsProfileApp.API.Models
{
    public class PSPhotoGallery
    {
        public int Id { get; set; }
        public string DisplayLabel { get; set; }
        public string PhotoPackUrl { get; set; }
        public int QtyPhotos { get; set; }
        public List<PSPreviewPhotoUrl> PreviewPhotosUrls { get; set; }
        public int PSProfileId { get; set; }
    }
}