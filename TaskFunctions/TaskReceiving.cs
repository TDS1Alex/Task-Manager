using System;
using System.Linq;

using Task_Manager.Storage;
using Task_Manager.UI;
using Task_Manager.TaskStatus;

namespace Task_Manager.TaskFunctions
{
    class TaskReceiving: ITaskReceiving
    {
        public void Receiving()
        {
            // Получаем задачи из бд
            using DbStorage db = new();
            Task? task = db.Task.FirstOrDefault();
            ChangeStatus changeStatus = new();
            MenuInformer menuInformer = new();

            if (task != null)
            {
                var users = db.Task.ToList();
                menuInformer.TaskList();
                foreach (Task _task in users)
                {
                    Console.WriteLine($"{_task.Id}) {_task.Name} ({_task.Status})");
                }

                menuInformer.TaskChoice();
                string choiceTask = Console.ReadLine();
                foreach (Task _task in users)
                {
                    if (_task.Id.ToString() == choiceTask)
                    {                        
                        DateTime dateReceiving = DateTime.Now;
                        System.TimeSpan time = dateReceiving - _task.DateCreated;
                        
                        TaskDescription taskDescription = new();
                        taskDescription.Description(_task.Name, _task.Description, _task.Status, time.Hours);
                    }
                }

                changeStatus.ChoiceAction();
                string choice = Console.ReadLine();
                changeStatus.Status(task,choice);
                db.SaveChanges();

                menuInformer.ChoiceAction();
            }
            else Console.WriteLine("Заданных задач нет");
        }
    }
}
