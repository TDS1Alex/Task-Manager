using System;

using Task_Manager.Storage;
using Task_Manager.UI;
using Task_Manager.TaskStatus;
using Task_Manager.Domain;

namespace Task_Manager.TasksAdd
{
    class TaskAdd: ITaskAdd
    {       
        private readonly ITaskDateCreated _taskDateCreated;
        private readonly ITaskChoiceStatus _taskChoiceStatus;
        private readonly ITaskDescription _taskDescription;
        private readonly ISetStatus _setStatus;
        private readonly IStorage _storage;

        public TaskAdd(ITaskDateCreated taskDateCreated, ITaskChoiceStatus taskChoiceStatus, ITaskDescription taskDescription, ISetStatus setStatus, IStorage storage)
        {
            _taskDateCreated = taskDateCreated;
            _taskChoiceStatus = taskChoiceStatus;
            _taskDescription = taskDescription;
            _setStatus = setStatus;
            _storage = storage;
        }

        // Создаем задачу
        public void Add()
        {                      
            // Пишем название задачи
            string nameTask = Console.ReadLine();
            Task task = new() { Name = nameTask };

            // Устанавливаем время для задачи           
            _taskDateCreated.DateCreated(task);

            // Задаем статус для задачи
            _taskChoiceStatus.ChoiceStatus(task, _setStatus);

            // Даем описание задачи
            _taskDescription.SetDescription(task);

            //Добавляем задачу в базу данных и сохраняем
            _storage.Add_Save(task);
        }
    }
}
