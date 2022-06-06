using System;

using Task_Manager.TaskStatus;
using Task_Manager.Domain;

namespace Task_Manager.TasksAdd
{
    public class TaskChoiceStatus: ITaskChoiceStatus
    {
        public void ChoiceStatus(Task task, ISetStatus setStatus)
        {
            setStatus.ChoiceAction();
            string choiceStatus = Console.ReadLine();
            setStatus.Status(task, choiceStatus);
        }
    }
}
