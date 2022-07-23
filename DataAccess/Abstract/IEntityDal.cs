using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityDal<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);   
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T Get(Expression<Func<T, bool>> filter = null);
    }
}
