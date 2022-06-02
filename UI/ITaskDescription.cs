using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.UI
{
    interface ITaskDescription
    {
        void Description(string name, string description, string status, int time);
        void SetDescription(MenuInformer menuInformer, Task task);
    }
}
