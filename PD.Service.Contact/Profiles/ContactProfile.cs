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
            CreateMap<ContactUpdateDomainModel, Models.Contact>().ForMember(x => x.ID, opt => opt.Ignore()).ReverseMap();

            CreateMap<Models.Contact, ContactQueryDomainModel>()
                .ForMember(dest => dest.ContactInfoList, src => src.MapFrom(q => q.ContactInfos));
        }
    }
}
