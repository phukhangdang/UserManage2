using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database;
using UserManage.Database.Entities;

namespace UserManage.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext dbContext;
        public IGenericRepository<User> UserRepository { get; private set; }
        public IGenericRepository<UserRole> UserRoleRepository { get; private set; }
        public UnitOfWork(DatabaseContext context)
        {
            this.dbContext = context;
            InitRepositories();
        }
        private void InitRepositories()
        {
            UserRepository = new GenericRepository<User>(dbContext);
            UserRoleRepository = new GenericRepository<UserRole>(dbContext);
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
