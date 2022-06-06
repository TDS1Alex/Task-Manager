using System;
using System.Linq;

using Task_Manager.Storage;
using Task_Manager.TaskStatus;
using Task_Manager.Domain;
using Task_Manager.UI;

namespace Task_Manager.TasksReceiving
{
    public class TaskReceiving: ITaskReceiving
    {
        private readonly ISetStatus _setStatus;
        private readonly ITaskList _taskList;

        public TaskReceiving(ISetStatus changeStatus, ITaskList taskList)
        {
            _setStatus = changeStatus;
            _taskList = taskList;
        }

        public void Receiving()
        {
            // Получаем задачи из бд
            using DbStorage db = new();
            Task? task = db.Task.FirstOrDefault();

            if (task != null)
            {
                // Вывод списка задач и выбор задачи для получения подробностей
                _taskList.ListAndSelection();

                // Изменения статуса задачи
                _setStatus.UserSelection(task);
            }
            else Console.WriteLine("Заданных задач нет");
        }
    }
}
