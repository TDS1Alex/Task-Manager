using System;

using Task_Manager.Domain;
using Task_Manager.Storage;

namespace Task_Manager.TaskStatus
{
    public class SetStatus : ISetStatus
    {
        public void Status(Task task, string choice)
        {
            task.Status = choice switch
            {
                "1" => StatusConstants.InPlans,
                "2" => StatusConstants.InProcess,
                "3" => StatusConstants.Stopped,
                "4" => StatusConstants.Done,
                _ => StatusConstants.StatusNoSet,
            };
        }

        public void ChoiceAction()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Задайте статус для задачи:");
            Console.WriteLine("1. В планах \n2. В процессе \n3. Остановлена \n4. Выполнена");
            Console.WriteLine("-------");
        }

        public void UserSelection(Task task)
        {
            using DbStorage db = new();

            ChoiceAction();
            string choice = Console.ReadLine();
            Status(task, choice);
            db.SaveChanges();
        }
    }
}
