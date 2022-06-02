using System;

namespace Task_Manager.UI
{
    public class MenuInformer: IMenuInformer
    {
        readonly Manager manager = new();

        public void Hello()
        {
            Console.WriteLine("Добро пожаловать в Менеджер задач!");
            ChoiceAction();
        }
        public void ChoiceAction()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Выберите следующее действие:");
            Console.WriteLine("1. Создать новую задачу");
            Console.WriteLine("2. Посмотреть созданные задачи");
            Console.WriteLine("-----------------------------");
            manager.MenuChoice();
        }

        public void TaskList()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Задачи:");
        }
        public void TaskChoice()
        {
            Console.WriteLine("-------");
            Console.WriteLine("Выберите задачу, чтобы получить более подробную информацию");
            Console.WriteLine("-------");
        }
        public void TaskDescription()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Дайте краткое описание Вашей задачи:");
        }
    }
}
