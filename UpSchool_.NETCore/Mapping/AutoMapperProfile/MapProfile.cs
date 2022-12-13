using AutoMapper;
using UpSchool.EntityLayer.Concrete;

using UpSchool_.NETCore.DTOLayer.DTOs.ContactDTOs;


namespace UpSchool_.NETCore.Mapping.AutoMapperProfile
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<ContactAddDto, Contact>();
            CreateMap<Contact, ContactAddDto>();

            CreateMap<ContactListDto, Contact>();
            CreateMap<Contact, ContactListDto>();

            CreateMap<ContactUpdateDto, Contact>();
            CreateMap<Contact, ContactUpdateDto>();

           
        }
    }
}
