using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManage.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Get();
        public TEntity GetByID(object id);
        public void Insert(TEntity entity);
        public void Delete(object id);
        public void Update(TEntity entityToUpdate);
    }
}
