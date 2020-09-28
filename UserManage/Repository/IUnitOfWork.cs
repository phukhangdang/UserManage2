using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;

namespace UserManage.Repository
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<UserRole> UserRoleRepository { get; }
        void Save();
    }
}
