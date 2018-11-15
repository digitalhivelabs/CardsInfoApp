namespace CardsProfileApp.API.Models
{
    public class PSDataSpec
    {
        public int Id { get; set; }
        public string DisplayLabel { get; set; }  
        public string DisplayValue { get; set; }
        public int PSProfileId { get; set; }
    }
}