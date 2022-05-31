using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
    }
}
