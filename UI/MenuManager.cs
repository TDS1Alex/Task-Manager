using System;

using Task_Manager.TaskFunctions;

namespace Task_Manager.UI
{
    public class MenuManager
    {
        public static void Hello()
        {
            Console.WriteLine("Добро пожаловать в Менеджер задач!");
            ChoiceAction();
        }
        public static void ChoiceAction()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Выберите следующее действие:");
            Console.WriteLine("1. Создать новую задачу");
            Console.WriteLine("2. Посмотреть созданные задачи");
            Console.WriteLine("-----------------------------");
            MenuChoice();
        }
        public static void MenuChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {               
                default:

                    Console.WriteLine("Напишите название новой задачи:");
                    TaskAdd.Add();
                    ChoiceAction();
                    break;

                case "2":

                    TaskReceiving.Receiving();
                    break;
            }
        }
        public static void TaskList()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Задачи:");
        }
        public static void TaskChoice()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Выберите задачу, чтобы получить более подробную информацию");
            Console.WriteLine("-------");
        }
        public static void TaskDescription()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Дайте краткое описание Вашей задачи:");
        }
    }
}
