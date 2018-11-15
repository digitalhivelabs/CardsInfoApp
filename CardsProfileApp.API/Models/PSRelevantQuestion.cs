namespace CardsProfileApp.API.Models
{
    public class PSRelevantQuestion
    {
        public int Id { get; set; }
        public string SourceSite { get; set; }
        public string SourceUrl { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int PSProfileId { get; set; }
    }
}