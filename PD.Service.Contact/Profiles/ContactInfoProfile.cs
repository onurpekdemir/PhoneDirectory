using AutoMapper;
using PD.Service.Contact.DomainModels.Contact;
using PD.Service.Contact.DomainModels.ContactInfo;
using PD.Service.Contact.Extensions;
using System.ComponentModel.DataAnnotations;

namespace PD.Service.Contact.Profiles
{
    public class ContactInfoProfile : Profile
    {
        public ContactInfoProfile()
        {
            CreateMap<ContactInfoCreateDomainModel, Models.ContactInfo>().ReverseMap();

            CreateMap<Models.ContactInfo, ContactInfoQueryDomainModel>()
                .ForMember(dest => dest.ContactInfoType, 
                            src => src.MapFrom(q => q.ContactInfoType.GetAttribute<DisplayAttribute>().Name)).ReverseMap();
        }
    }
}
