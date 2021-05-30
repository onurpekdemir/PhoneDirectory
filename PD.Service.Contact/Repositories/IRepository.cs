using PD.Service.Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IList<T> List();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
