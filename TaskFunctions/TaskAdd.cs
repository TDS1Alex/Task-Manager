using System;

using Task_Manager.Storage;
using Task_Manager.UI;

namespace Task_Manager.TaskFunctions
{
    class TaskAdd
    {
        // Создаем задачу
        public static void Add()
        {           
            using DbStorage db = new();
            
            // Пишем название задачи                       
            string nameTask = Console.ReadLine();
            Task task = new() { Name = nameTask };
            EStatus eStatus = new();

            // Устанавливаем время для задачи
            DateTime _dateCreated = DateTime.Now;
            task.DateCreated = _dateCreated;
            Console.WriteLine($"Дата создания задачи установлена: {_dateCreated:f}");

            // Задаем статус для задачи
            eStatus.ChoiceAction();
            string choiceStatus = Console.ReadLine();
            eStatus.Status(task, choiceStatus);

            // Даем описание задачи
            MenuManager.TaskDescription();
            string descriprion = Console.ReadLine();
            task.Description = descriprion;

            db.Task.Add(task);
            db.SaveChanges();
        }
    }
}
