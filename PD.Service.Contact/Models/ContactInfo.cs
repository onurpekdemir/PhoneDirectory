using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Models
{
    public class ContactInfo : BaseEntity
    {
        public ContactInfoType ContactInfoType { get; set; }
        public string ContactInfoContent { get; set; }

        public Contact Contact { get; set; }
        public int ContactId { get; set; }
    }
}
