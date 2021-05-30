using PD.Service.Contact.DomainModels.ContactInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.DomainModels.Contact
{
    public class ContactQueryDomainModel : IDomainModelBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Firm { get; set; }
        public List<ContactInfoQueryDomainModel> ContactInfoList { get; set; }
    }
}
