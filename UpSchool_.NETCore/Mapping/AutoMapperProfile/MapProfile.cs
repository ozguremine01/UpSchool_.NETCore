using AutoMapper;
using UpSchool.EntityLayer.Concrete;
using UpSchool_.NETCore.DTOLayer.CustomerDTOs;
using UpSchool_.NETCore.DTOLayer.DTOs.ContactDTOs;
using UpSchool_.NETCore.DTOLayer.SupplierDTOs;

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

            CreateMap<CustomerAddDTO, Contact>();
            CreateMap<Contact, CustomerAddDTO>();
        }
    }
}
