using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cedro.Restoration.Repo.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(Func<T, bool> query);
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
