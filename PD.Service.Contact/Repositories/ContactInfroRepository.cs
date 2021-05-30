using PD.Service.Contact.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public class ContactInfoRepository : BaseRepository<Models.ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(ContactContext contactContext) : base(contactContext)
        {
        }
    }
}
