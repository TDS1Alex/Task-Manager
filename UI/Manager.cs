using System;

using Task_Manager.TasksAdd;
using Task_Manager.TasksReceiving;

namespace Task_Manager.UI
{
    public class Manager: IManager
    {
        private readonly ITaskReceiving _taskReceiving;
        private readonly ITaskAdd _taskAdd;

        public Manager(ITaskReceiving taskReceiving, ITaskAdd taskAdd)
        {
            _taskReceiving = taskReceiving;
            _taskAdd = taskAdd;
        } 

        public void MenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                default:

                    //Создаем задачу
                    Console.WriteLine("Напишите название новой задачи:");
                    _taskAdd.Add();

                    //Перезапускаем метод
                    ChoiceAction();
                    MenuChoice();
                    break;

                case "2":

                    //Получаем созданные задачи
                    _taskReceiving.Receiving();
                    ChoiceAction();
                    MenuChoice();
                    break;
            }
        }

        public void ChoiceAction()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Выберите следующее действие:");
            Console.WriteLine("1. Создать новую задачу");
            Console.WriteLine("2. Посмотреть созданные задачи");
            Console.WriteLine("-----------------------------");
        }
    }
}
