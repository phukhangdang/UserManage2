using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;
using UserManage.Services.BaseService;

namespace UserManage.Services.UserService
{
    public interface IUserService : IBaseService<User>
    {
    }
}
