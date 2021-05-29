using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Models
{
    public class Contact : BaseEntity
    {
        public Contact()
        {
            UUID = Guid.NewGuid();
            ContactInfos = new List<ContactInfo>();
        }

        public Guid UUID { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Firm { get; set; }

        public ICollection<ContactInfo> ContactInfos { get; set; }

    }
}
