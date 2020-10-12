using global::AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Repository;

namespace UserManage.Services.BaseService
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected abstract IGenericRepository<TEntity> _reponsitory { get; }
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual void Create(TEntity entity)
        {
            _reponsitory.Insert(entity);
            _unitOfWork.Save();
        }

        public virtual void DeleteByID(int id)
        {
            _reponsitory.Delete(id);
            _unitOfWork.Save();
        }

        public virtual TEntity GetByID(int id)
        {
            return _reponsitory.GetByID(id);
        }

        public virtual IEnumerable<TEntity> Gets(int pageNum, int pageSize)
        {
            return _reponsitory.Get(pageNum, pageSize);
        }

        public virtual void Update(TEntity entity)
        {
            _reponsitory.Update(entity);
            _unitOfWork.Save();
        }
    }
}
