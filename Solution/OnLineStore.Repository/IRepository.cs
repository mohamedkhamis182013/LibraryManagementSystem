﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace OnLineStore.Repository
{
    public interface IRepository<T>
    {

        IQueryable<T> GetByFilter( Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,string includeProperties = "");
        IQueryable<T> GetAll();
        T GetByID(object id);
        void Insert(T entity);
        void Delete(object id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        

    }
}
