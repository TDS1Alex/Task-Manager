using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task_Manager.TaskStatus;

namespace Task_Manager.TaskFunctions
{
    interface ITaskChoiceStatus
    {
        void ChoiceStatus(Task task, SetStatus setStatus);
    }
}
