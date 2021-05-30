using PD.Service.Contact.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContactContext _contactContext;

        public UnitOfWork(ContactContext contactContext)
        {
            _contactContext = contactContext;
        }

        public int Save()
        {
            return _contactContext.SaveChanges();
        }
    }
}
