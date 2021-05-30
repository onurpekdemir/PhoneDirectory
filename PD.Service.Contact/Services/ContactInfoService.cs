using AutoMapper;
using PD.Service.Contact.DomainModels.ContactInfo;
using PD.Service.Contact.Repositories;
using PD.Service.Contact.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Services
{
    public class ContactInfoService : IContactInfoService
    {
        private readonly IContactInfoRepository _contactInfoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactInfoService(IContactInfoRepository contactInfoRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contactInfoRepository = contactInfoRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _contactInfoRepository.Delete(id);
        }

        public int Insert(ContactInfoCreateDomainModel model)
        {
            var entity = _mapper.Map<Models.ContactInfo>(model);
            _contactInfoRepository.Insert(entity);
            return _unitOfWork.Save();
        }
    }
}
