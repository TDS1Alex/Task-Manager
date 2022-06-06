using System;
using System.Linq;

using Task_Manager.UI;
using Task_Manager.Storage;
using Task_Manager.Domain;

namespace Task_Manager.TasksReceiving
{
    public class TaskList: ITaskList
    {
        private readonly ITaskDescription _taskDescription;

        public TaskList(ITaskDescription taskDescription)
        {
            _taskDescription = taskDescription;
        }

        public void ListAndSelection()
        {
            using DbStorage db = new();
            var users = db.Task.ToList();

            Console.WriteLine("-------");
            Console.WriteLine("Задачи:");
            foreach (Task _task in users)
            {
                Console.WriteLine($"{_task.Id}) {_task.Name} ({_task.Status})");
            }

            Console.WriteLine("-------");
            Console.WriteLine("Выберите задачу, чтобы получить более подробную информацию");
            Console.WriteLine("-------");

            string choiceTask = Console.ReadLine();
            foreach (Task _task in users)
            {
                if (_task.Id.ToString() == choiceTask)
                {
                    DateTime dateReceiving = DateTime.Now;
                    System.TimeSpan time = dateReceiving - _task.DateCreated;
                    _taskDescription.Description(_task.Name, _task.Description, _task.Status, time.Hours);
                }
            }
        }
    }
}
