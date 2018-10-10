using System;

namespace CardsProfileApp.API.Models
{
    public class ProfileCard
    {
        public int Id { get; set; }
        public string ArtisticName { get; set; }
        public string RealName { get; set; }
        public DateTime BirthDate { get; set; }     
        public string BirthPlace { get; set; }    

    }
}