using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.UOW
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
