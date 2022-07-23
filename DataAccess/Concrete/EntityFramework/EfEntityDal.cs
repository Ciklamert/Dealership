using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityDal<T> : IEntityDal<T> where T : class,IEntity,new()
    {
        Context c = new Context();
        DbSet<T> _object;
        public EfEntityDal()
        {
            _object = c.Set<T>();
        }
        public void Add(T item)
        {
            var addedEntity = c.Entry(item);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public void Delete(T item)
        {
            var removedEntity = c.Entry(item);  
            removedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            return _object.SingleOrDefault(filter);
        }

        

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _object.ToList() : _object.Where(filter).ToList();
        }

        

        public void Update(T item)
        {
            var updatedEntity = c.Entry(item);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
