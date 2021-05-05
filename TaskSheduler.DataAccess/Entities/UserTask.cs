using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.DataAccess.Entities.Enum;

namespace TaskSheduler.DataAccess.Entities
{
    public class UserTask
    {
        public int Id { get; set; }
        public string NameOfTask { get; set; }
        public string Description { get; set; }
        public DateTime StartOfTask { get; set; }
        public DateTime DeadLine { get; set; }
        public StatusTask Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
