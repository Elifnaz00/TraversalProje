using AutoMapper;
using DataAccesLayer.Migrations;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrate;
using Announcement = EntityLayer.Concrate.Announcement;

namespace TraversalProje.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserRegisterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement, AnnouncementListDto>(); 

            CreateMap<Announcement, AnnouncementAddDto>();
            CreateMap<AnnouncementAddDto , Announcement>();

            CreateMap<Announcement, AnnouncementUpdateDto>();
            CreateMap<AnnouncementUpdateDto, Announcement>();

            CreateMap<ContactUs, SendMessageDto>(); //.ReverseMap()
            CreateMap<SendMessageDto, ContactUs>(); 

        }
    }
}
