using PD.Service.Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.DomainModels.ContactInfo
{
    public class ContactInfoQueryDomainModel
    {
        public string ContactInfoType { get; set; }
        public string ContactInfoContent { get; set; }
    }
}
