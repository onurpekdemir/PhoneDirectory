using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.DomainModels.Contact
{
    public class ContactCreateDomainModel : IDomainModelBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Firm { get; set; }
    }
}
