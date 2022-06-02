using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task_Manager.TaskFunctions;

namespace Task_Manager.UI
{
    public class Manager: IManager
    {
        public void MenuChoice()
        {
            MenuInformer menuInformer = new();
            TaskAdd taskAdd = new();
            TaskReceiving taskReceiving = new();

            string choice = Console.ReadLine();
            switch (choice)
            {
                default:

                    Console.WriteLine("Напишите название новой задачи:");
                    taskAdd.Add();
                    menuInformer.ChoiceAction();
                    break;

                case "2":

                    taskReceiving.Receiving();
                    break;
            }
        }
    }
}
