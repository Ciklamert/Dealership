﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityDal<T>
    {
        List<T> GetAll();   
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
    }
}
