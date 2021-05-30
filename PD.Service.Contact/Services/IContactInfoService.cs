using PD.Service.Contact.DomainModels.ContactInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Services
{
    public interface IContactInfoService
    {
        int Insert(ContactInfoCreateDomainModel entity);
        void Delete(int id);
    }
}
