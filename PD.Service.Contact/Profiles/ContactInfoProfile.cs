using AutoMapper;
using PD.Service.Contact.DomainModels.Contact;
using PD.Service.Contact.DomainModels.ContactInfo;

namespace PD.Service.Contact.Profiles
{
    public class ContactInfoProfile : Profile
    {
        public ContactInfoProfile()
        {
            CreateMap<ContactInfoCreateDomainModel, Models.ContactInfo>().ReverseMap();
        }
    }
}
