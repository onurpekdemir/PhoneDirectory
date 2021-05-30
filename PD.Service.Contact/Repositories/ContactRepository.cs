using PD.Service.Contact.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public class ContactRepository : BaseRepository<Models.Contact> , IContactRepository
    {
        public ContactRepository(ContactContext contactContext) : base(contactContext)
        {
        }
    }
}
