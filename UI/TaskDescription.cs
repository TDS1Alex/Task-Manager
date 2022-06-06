using System;

using Task_Manager.Domain;

namespace Task_Manager.UI
{
    public class TaskDescription: ITaskDescription
    {
        public void Description(string name, string description, string status, int time)
        {
            Console.WriteLine("-------");
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Затраченное время: {time} часов");
            Console.WriteLine($"Статус: {status}");
        }

        public void SetDescription(Task task)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Дайте краткое описание Вашей задачи:");

            string descriprion = Console.ReadLine();
            task.Description = descriprion;
        }
    }
}
