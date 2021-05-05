using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.DataAccess.Entities.Enum;

namespace TaskSheduler.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Rule Rule { get; set; }

        public ICollection<UserTask> UserTask { get; set; }
    }
}
