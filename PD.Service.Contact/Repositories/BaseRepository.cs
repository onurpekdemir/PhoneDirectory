using Microsoft.EntityFrameworkCore;
using PD.Service.Contact.Data;
using PD.Service.Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ContactContext _contactContext;

        public BaseRepository(ContactContext contactContext)
        {
            _contactContext = contactContext;
        }

        public void Delete(int id)
        {
            var entity = this.Get(id);
            _contactContext.Set<T>().Remove(entity);
        }

        public T Get(int id)
        {
            return _contactContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _contactContext.Set<T>().Add(entity);
        }

        public IList<T> List()
        {
            return _contactContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _contactContext.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
