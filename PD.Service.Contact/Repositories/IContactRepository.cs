using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public interface IContactRepository : IRepository<Models.Contact>
    {
        Models.Contact GetWithContactInfo(int id);
    }
}
