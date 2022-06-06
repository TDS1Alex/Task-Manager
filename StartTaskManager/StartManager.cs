using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task_Manager.UI;

namespace Task_Manager.StartTaskManager
{
    public class StartManager: IStartManager
    {
        private readonly IManager _manager;

        public StartManager(IManager manager)
        {
            _manager = manager;
        }

        public void Start()
        {
            Console.WriteLine("Добро пожаловать в Менеджер задач!");

            _manager.ChoiceAction();
            _manager.MenuChoice();
        }
    }
}

