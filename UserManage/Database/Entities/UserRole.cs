using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManage.Database.Entities
{
    public class UserRole
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public string Role { get; set; }
    }
}
