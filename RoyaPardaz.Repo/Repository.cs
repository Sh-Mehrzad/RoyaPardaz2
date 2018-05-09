using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
using RoyaPardaz.Data;

namespace RoyaPardaz.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DBContext dBContext;
        private DbSet<T> entities;

        public Repository(DBContext dbContext)
        {
            this.dBContext = dbContext;
            entities = this.dBContext.Set<T>();
        }
        public int Commit()
        {
            return dBContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return dBContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            dBContext.Remove(entity);
        }

        public T Get(long Id)
        {
            return entities.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entity.Created = DateTime.Now;
            entities.Add(entity);
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entity.Modified = DateTime.Now;
            // entity.isEnable=false;
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }          
            entity.Modified = DateTime.Now;
        }
    }
}
