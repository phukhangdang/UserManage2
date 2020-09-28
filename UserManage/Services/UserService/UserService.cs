using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;
using UserManage.Repository;
using UserManage.Services.BaseService;

namespace UserManage.Services.UserService
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        protected override IGenericRepository<User> _reponsitory => _unitOfWork.UserRepository;
    }
}
