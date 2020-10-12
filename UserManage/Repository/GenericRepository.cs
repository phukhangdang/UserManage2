using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database;

namespace UserManage.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DatabaseContext dbContext;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(DatabaseContext context)
        {
            this.dbContext = context;
            this.dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> Get(int pageNum, int pageSize)
        {
            var entity = from e in dbSet.Skip(pageNum * pageSize).Take(pageSize)
                         select e;
            return entity;
        }
        public virtual TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
