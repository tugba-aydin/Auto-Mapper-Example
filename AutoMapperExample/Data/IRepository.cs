﻿using System.Collections.Generic;

namespace AutoMapperExample.Data
{
    public interface IRepository<T> where T:class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SaveAll();
    }
}
