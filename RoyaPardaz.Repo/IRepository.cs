using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RoyaPardaz.Data;

namespace RoyaPardaz.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Remove(T entity);

        int Commit();
        Task<int> CommitAsync();
    }
}
