using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManage.Services.BaseService
{
    public interface IBaseService<TEntity>
        where TEntity : class
    {
        public IEnumerable<TEntity> Gets(int pageNum, int pageSize);
        public TEntity GetByID(int id);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void DeleteByID(int id);
    }
}
