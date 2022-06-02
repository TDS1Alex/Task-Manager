using System;

namespace Task_Manager.TaskStatus
{
    public class SetStatus : IEstablishingStatus
    {
        public void Status(Task task, string choice)
        {
            task.Status = choice switch
            {
                "1" => IEstablishingStatus.InPlans,
                "2" => IEstablishingStatus.InProcess,
                "3" => IEstablishingStatus.Stopped,
                "4" => IEstablishingStatus.Done,
                _ => IEstablishingStatus.StatusNoSet,
            };
        }
        public void ChoiceAction()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Задайте статус для задачи:");
            Console.WriteLine("1. В планах \n2. В процессе \n3. Остановлена \n4. Выполнена");
        }
    }
}
