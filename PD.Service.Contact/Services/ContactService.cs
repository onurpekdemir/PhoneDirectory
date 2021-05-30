using AutoMapper;
using PD.Service.Contact.DomainModels.Contact;
using PD.Service.Contact.Repositories;
using PD.Service.Contact.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public ContactQueryDomainModel Get(int id)
        {
            var contact = _contactRepository.Get(id);
            return _mapper.Map<ContactQueryDomainModel>(contact);
        }

        public ContactQueryDomainModel GetWithContactInfo(int id)
        {
            var contact = _contactRepository.GetWithContactInfo(id);
            return _mapper.Map<ContactQueryDomainModel>(contact);
        }

        public int Insert(ContactCreateDomainModel model)
        {
            var entity = _mapper.Map<Models.Contact>(model);
            _contactRepository.Insert(entity);
            return _unitOfWork.Save();
        }

        public IList<ContactQueryDomainModel> List()
        {
            var contact = _contactRepository.List();
            return _mapper.Map<List<ContactQueryDomainModel>>(contact);
        }

        public int Update(ContactUpdateDomainModel model)
        {
            var entity = _mapper.Map<Models.Contact>(model);
            _contactRepository.Insert(entity);
            return _unitOfWork.Save();
        }
    }


}
