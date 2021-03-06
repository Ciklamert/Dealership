using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
    }
}
