using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.UI
{
    public class TaskDescription
    {
        public static void Description(string name, string description, string status, int time)
        {
            Console.WriteLine("-------");
            Console.WriteLine($"Название: {name}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Затраченное время: {time} часов");
            Console.WriteLine($"Статус: {status}");
            Console.WriteLine("-------");
        }
    }
}
