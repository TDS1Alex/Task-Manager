using System;

using Task_Manager.UI;

namespace Task_Manager.TaskStatus
{
    public class ChangeStatus : IEstablishingStatus
    {
        public void Status(Task task, string choice)
        {
            MenuInformer menuInformer = new();

            switch (choice)
            {
                case "1":
                    task.Status = IEstablishingStatus.InPlans;
                    break;
                case "2":
                    task.Status = IEstablishingStatus.InProcess;
                    break;
                case "3":
                    task.Status = IEstablishingStatus.Stopped;
                    break;
                case "4":
                    task.Status = IEstablishingStatus.Done;
                    break;
                case "5":
                    menuInformer.ChoiceAction();
                    break;
                default:
                    task.Status = IEstablishingStatus.StatusNoSet;
                    break;
            }
        }
        public void ChoiceAction()
        {
            Console.WriteLine("Вы можете поменять статус вашей задачи или выйти в меню:");
            Console.WriteLine("1. В планах \n2. В процессе \n3. Остановлена \n4. Выполнена \n5. Выйти в меню");
            Console.WriteLine("-------");
        }
    }
}
