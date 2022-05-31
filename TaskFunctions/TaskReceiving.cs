using System;
using System.Linq;

using Task_Manager.Storage;
using Task_Manager.UI;

namespace Task_Manager.TaskFunctions
{
    class TaskReceiving
    {
        public static void Receiving()
        {
            // Получаем задачи из бд
            using DbStorage db = new();

            Task? task = db.Task.FirstOrDefault();
            ChangeStatus changeStatus = new();

            if (task != null)
            {
                var users = db.Task.ToList();
                MenuManager.TaskList();
                foreach (Task t in users)
                {
                    Console.WriteLine($"{t.Id}) {t.Name} ({t.Status})");
                }

                MenuManager.TaskChoice();
                string choiceTask = Console.ReadLine();
                foreach (Task t in users)
                {
                    if (t.Id.ToString() == choiceTask)
                    {
                        DateTime dateReceiving = DateTime.Now;
                        System.TimeSpan time = dateReceiving - t.DateCreated;
                        TaskDescription.Description(t.Name, t.Description, t.Status, time.Hours);
                    }
                }

                changeStatus.ChoiceAction();
                string c = Console.ReadLine();
                changeStatus.Status(task,c);
                db.SaveChanges();

                MenuManager.ChoiceAction();
            }
            else Console.WriteLine("Заданных задач нет");
        }
    }
}
