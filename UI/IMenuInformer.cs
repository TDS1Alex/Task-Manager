using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.UI
{
    interface IMenuInformer
    {
        void Hello();
        void ChoiceAction();
        void TaskList();
        void TaskChoice();
        void TaskDescription();
    }
}
