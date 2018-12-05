using System;
using System.Collections.Generic;

namespace CardsProfileApp.API.DTOs.PSProfile
{
    public class PSProfileForDetailDTO
    {
        public int Id { get; set; }
        public string KnownName { get; set; }
        public string KnownNames { get; set; }     
        public DateTime BirthDate { get; set; }   
        public int Age { get; set; }
        public string Sign { get; set; }
        public string BirthPlace { get; set; }
        public string BirthCountry { get; set; }
        public string Residence { get; set; }
        public string ResidenceCountry { get; set; }
        public string PhotoUrl { get; set; }
        public string CareerStartYear { get; set; }
        public string CareerEndYear { get; set; }
        public string YearsInBusiness { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BodyType { get; set; }
        public string Measurements { get; set; }
        public string Breast { get; set; }
        public string Tattos { get; set; }
        public string Piercings { get; set; }
        public List<PSSocialNetworkDTO> SocialNetworks { get; set; }
        public string WhatWeKnow { get; set; }
        public string OtherRelatedInfo { get; set; }
        public int ScortingProfileId { get; set; }
        public List<PSDataSpectForDetailDTO> DataSpecifications { get; set; }
        public List<PSRelatedLinksForDetailsDTO> RelatedLinks { get; set; }
        public List<PSRelevantQuestionForDetailsDTO> RelevantQuestions { get; set; }
        public List<PSPhotoGalleryForDetailsDTO> PhotoGalleries { get; set; }
        public List<PSVideoGalleryForDetailsDTO> VideoGalleries { get; set; }

    }
}

