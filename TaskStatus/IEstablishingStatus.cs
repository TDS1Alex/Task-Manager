using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.TaskStatus
{
    interface IEstablishingStatus
    {
        const string InPlans  = "В планах";
        const string InProcess = "В процессе";
        const string Stopped  = "Остановлена";
        const string Done = "Выполнена";
        const string StatusNoSet = "Статус задачи не установлен";
        void Status(Task task, string choice);
        void ChoiceAction();
    }
}
