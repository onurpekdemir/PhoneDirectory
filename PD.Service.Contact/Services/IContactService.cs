using PD.Service.Contact.DomainModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Services
{
    public interface IContactService
    {
        ContactQueryDomainModel Get(int id);
        ContactQueryDomainModel GetWithContactInfo(int id);
        IList<ContactQueryDomainModel> List();
        int Insert(ContactCreateDomainModel entity);
        int Update(ContactUpdateDomainModel entity);
        void Delete(int id);
    }
}
