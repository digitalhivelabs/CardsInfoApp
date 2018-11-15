namespace CardsProfileApp.API.Models
{
    public class PSRelatedLink
    {
        public int Id { get; set; }
        public string DisplayLabel { get; set; }
        public string LinkUrl { get; set; }
        public int PSProfileId { get; set; }
    }
}