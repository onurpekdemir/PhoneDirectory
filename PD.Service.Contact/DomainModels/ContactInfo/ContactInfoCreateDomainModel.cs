using PD.Service.Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.DomainModels.ContactInfo
{
    public class ContactInfoCreateDomainModel : IDomainModelBase
    {
        public ContactInfoType ContactInfoType { get; set; }
        public string ContactInfoContent { get; set; }
        public int ContactId { get; set; }
    }
}
