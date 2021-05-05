using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSheduler.BusinessLayer.DTO
{
    class UserTaskDTO
    {
        public int Id { get; set; }
        public string NameOfTask { get; set; }
        public string Description { get; set; }
        public DateTime StartOfTask { get; set; }
        public DateTime DeadLine { get; set; }
        public string Status { get; set; }

        public int UserId { get; set; }
    }
}
