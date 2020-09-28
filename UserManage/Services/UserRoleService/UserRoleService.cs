using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;
using UserManage.Repository;
using UserManage.Services.BaseService;

namespace UserManage.Services.UserRoleService
{
    public class UserRoleService : BaseService<UserRole>, IUserRoleService
    {
        public UserRoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<UserRole> _reponsitory => _unitOfWork.UserRoleRepository;
    }
}
