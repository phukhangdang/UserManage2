using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;

namespace UserManage.Services.UpdateService
{
    interface ICreateService
    {
        void Create(User user, UserRole userRole);
    }
}
