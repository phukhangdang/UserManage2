using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;
using UserManage.Repository;
using UserManage.Services.UpdateService;

namespace UserManage.Services.CreateService
{
    public class CreateService : ICreateService
    {
        protected readonly IUnitOfWork _unitOfWork;
        // protected GenericRepository<User> userRepository { get; }
        // protected GenericRepository<UserRole> userRoleRepository { get; }
        public CreateService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(User user, UserRole userRole)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.UserRoleRepository.Insert(userRole);
            _unitOfWork.Save();
        }
    }
}
