using System;
using System.Linq;
using AutoMapper;
using CardsProfileApp.API.DTOs;
using CardsProfileApp.API.DTOs.PSProfile;
using CardsProfileApp.API.Models;

namespace CardsProfileApp.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, ProfileForListDTO>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt => {
                    opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<User, ProfileForDetailDTO>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt => {
                    opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<Photo, PhotosForDetailDTO>();
            CreateMap<UserForUpdateDTO, User>();
            CreateMap<Photo, PhotoForReturnDTO>();
            CreateMap<PhotoForCreationDTO, Photo>();
            CreateMap<UserForRegisterDTO, User>();
            CreateMap<MessageForCreationDTO, Message>().ReverseMap();
            CreateMap<Message, MessageToReturnDTO>()
                .ForMember(m => m.SenderPhotoUrl, opt => opt.MapFrom(
                    u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url
                ))
                .ForMember(m => m.RecipientPhotoUrl, opt => opt.MapFrom(
                    u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url
                ));

            //PSProfiles
            CreateMap<PSProfile, PSProfileForDetailDTO>()
                .ForMember(dest => dest.Age, opt => {
                    opt.ResolveUsing(d => d.BirthDate.CalculateAge());
                })
                .ForMember(dest => dest.Sign, opt => {
                    opt.ResolveUsing(d => d.BirthDate.CalculateAstrologicalSign());
                }).ForMember(dest => dest.CareerStartYear, opt => {
                    opt.ResolveUsing(d => {
                        if ( d.CareerStartYear > 0)
                            return d.CareerStartYear.ToString();
                        else
                            return string.Empty;
                    });
                }).ForMember(dest => dest.CareerEndYear, opt => {
                    opt.ResolveUsing(d => {
                        if ( d.CareerEndYear > 0)
                            return d.CareerEndYear.ToString();
                        else
                        {
                            if (d.IsStillInBusiness)
                                return DateTime.Now.Year.ToString();
                            else
                                return string.Empty;
                        }
                    });
                }).ForMember(dest => dest.YearsInBusiness, opt => {
                    opt.ResolveUsing(d => {
                        if ( d.CareerStartYear > 0 && d.CareerEndYear > 0)
                            return (d.CareerEndYear - d.CareerStartYear).ToString();
                        else
                            return string.Empty;
                    });
                }).ForMember(dest => dest.Height, opt => {
                    opt.ResolveUsing(d => {
                        if ( d.Height > 0)
                        {
                            string result;
                            result = d.Height.ToString() + " cm ";

                            double inches = d.Height/2.54;
                            double feet = Math.Floor(inches / 12);
                            inches -=  (feet*12);

                            result += "( " + feet.ToString() + "'" + Convert.ToInt32(inches).ToString() + " )";

                            return result;
                        }
                        else
                            return string.Empty;
                    });
                }).ForMember(dest => dest.Weight, opt => {
                    opt.ResolveUsing(d => {
                        if ( d.Weight > 0)
                        {
                            string result;
                            result = d.Weight.ToString() + " lbs. ";

                            result += "(" + (d.Weight/2.2).ToString("###.00") + " Kg.)";

                            return result;
                        }
                        else
                            return string.Empty;
                    });
                }).ForMember(dest => dest.KnownNames, opt => {
                    opt.ResolveUsing(d => {
                        string result = string.Empty;

                        if (d.KnownAsNames != null)
                        {
                            string[] knames = d.KnownAsNames.Select(kn => kn.DisplayName).ToArray();
                            result = string.Join(", ", knames);
                        }

                        return result;
                    });
                });

        }
    }
}