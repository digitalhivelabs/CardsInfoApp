using System.Collections.Generic;

namespace CardsProfileApp.API.DTOs.PSProfile
{
    public class PSPhotoGalleryForDetailsDTO
    {
        public int Id { get; set; }
        public string DisplayLabel { get; set; }
        public string PhotoPackUrl { get; set; }
        public int QtyPhotos { get; set; }
        public List<PSPreviewPhotoUrlForDetailsDTO> PreviewPhotosUrls { get; set; }
    }
}
