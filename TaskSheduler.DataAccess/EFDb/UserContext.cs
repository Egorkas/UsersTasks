using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.DataAccess.Entities;

namespace TaskSheduler.DataAccess.EFDb
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("UsersTasksDB")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
    }
}
