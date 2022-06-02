using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.TaskFunctions
{
    public class TaskDateCreated: ITaskDateCreated
    {
        public void DateCreated(Task task)
        {
            DateTime _dateCreated = DateTime.Now;
            task.DateCreated = _dateCreated;
            Console.WriteLine($"Дата создания задачи установлена: {_dateCreated:f}");
        }
    }
}
