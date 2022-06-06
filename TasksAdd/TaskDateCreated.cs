using System;

using Task_Manager.Domain;

namespace Task_Manager.TasksAdd
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
