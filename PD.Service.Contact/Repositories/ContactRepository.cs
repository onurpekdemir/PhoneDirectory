using Microsoft.EntityFrameworkCore;
using PD.Service.Contact.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public class ContactRepository : BaseRepository<Models.Contact> , IContactRepository
    {
        private readonly ContactContext _contactContext;
        public ContactRepository(ContactContext contactContext) : base(contactContext)
        {
            _contactContext = contactContext;
        }

        public Models.Contact GetWithContactInfo(int id)
        {
            return _contactContext.Contacts
                .Include(s => s.ContactInfos)
                .FirstOrDefault(s => s.ID == id);
        }
    }
}
