using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task_Manager.UI;

namespace Task_Manager
{
    public abstract class EstablishingStatus
    {
        public string InPlans { get; set; } = "В планах";
        public string InProcess { get; set; } = "В процессе";
        public string Stopped { get; set; } = "Остановлена";
        public string Done { get; set; } = "Выполнена";
        public string StatusNoSet { get; set; } = "Статус задачи не установлен";
        public abstract void Status(Task task, string choice);
        public abstract void ChoiceAction();
    }
    public class ChangeStatus : EstablishingStatus
    {
        public override void Status(Task task, string choice)
        {
            switch (choice)
            {
                case "1":
                    task.Status = InPlans;
                    break;
                case "2":
                    task.Status = InProcess;
                    break;
                case "3":
                    task.Status = Stopped;
                    break;
                case "4":
                    task.Status = Done;
                    break;
                case "5":
                    MenuManager.ChoiceAction();
                    break;
                default:
                    task.Status = StatusNoSet;
                    break;
            }
        }
        public override void ChoiceAction()
        {
            Console.WriteLine("Вы можете поменять статус вашей задачи или выйти в меню:");
            Console.WriteLine("1. В планах \n2. В процессе \n3. Остановлена \n4. Выполнена \n5. Выйти в меню");
            Console.WriteLine("-------");
        }
    }

    public class EStatus : EstablishingStatus
    {
        public override void Status(Task task, string choice)
        {
            task.Status = choice switch
            {
                "1" => InPlans,
                "2" => InProcess,
                "3" => Stopped,
                "4" => Done,
                _ => StatusNoSet,
            };
        }
        public override void ChoiceAction()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Задайте статус для задачи:");
            Console.WriteLine("1. В планах \n2. В процессе \n3. Остановлена \n4. Выполнена");
        }
    }
}
