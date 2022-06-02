using System;

using Task_Manager.Storage;
using Task_Manager.UI;
using Task_Manager.TaskStatus;

namespace Task_Manager.TaskFunctions
{
    class TaskAdd: ITaskAdd
    {
        // Создаем задачу
        public void Add()
        {           
            using DbStorage db = new();

            // Пишем название задачи
            string nameTask = Console.ReadLine();
            Task task = new() { Name = nameTask };
            SetStatus setStatus = new();
            MenuInformer menuInformer = new();
            TaskDateCreated taskDateCreated = new();
            TaskChoiceStatus taskChoiceStatus = new();
            TaskDescription taskDescription = new(); 

            // Устанавливаем время для задачи           
            taskDateCreated.DateCreated(task);

            // Задаем статус для задачи
            taskChoiceStatus.ChoiceStatus(task, setStatus);

            // Даем описание задачи
            taskDescription.SetDescription(menuInformer, task);

            db.Task.Add(task);
            db.SaveChanges();
        }
    }
}
