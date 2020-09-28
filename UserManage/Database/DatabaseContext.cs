using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManage.Database.Entities;

namespace UserManage.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-QQ4A2OU; initial catalog=UserManage; persist security info=True; user id=sa; password=12;");
        }
    }
}
