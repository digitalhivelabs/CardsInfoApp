using System;
using System.Collections.Generic;

namespace CardsProfileApp.API.Models
{
    public class PSProfile
    {
        public int Id { get; set; }
        public string KnownName { get; set; }
        public List<PSKnownAsName> KnownAsNames { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string BirthCountry { get; set; }
        public string Residence { get; set; }
        public string ResidenceCountry { get; set; }
        public int CareerStartYear { get; set; }    
        public int CareerEndYear { get; set; }
        public bool IsStillInBusiness { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string BodyType { get; set; }
        public string Measurements { get; set; }
        public string Breast { get; set; }
        public string Tattos { get; set; }
        public string Piercings { get; set; }
        public int ScortingProfileId { get; set; }
        public string PhotoUrl { get; set; }
        public List<PSSocialNetwork> SocialNetworks { get; set; }
        public string WhatWeKnow { get; set; }
        public string OtherRelatedInfo { get; set; }
        public List<PSRelatedLink> RelatedLinks { get; set; }
        public List<PSDataSpec> DataSpecifications { get; set; }
        public List<PSRelevantQuestion> RelevantQuestions { get; set; }
        public List<PSPhotoGallery> PhotoGalleries { get; set; }
        public List<PSVideoGallery> VideoGalleries { get; set; }
    }
}