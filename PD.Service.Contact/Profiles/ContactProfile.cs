using AutoMapper;
using PD.Service.Contact.DomainModels.Contact;

namespace PD.Service.Contact.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactCreateDomainModel, Models.Contact>().ReverseMap();
            CreateMap<ContactQueryDomainModel, Models.Contact>().ReverseMap();
            CreateMap<ContactUpdateDomainModel, Models.Contact>().ReverseMap();
        }
    }
}
