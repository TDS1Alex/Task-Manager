using System;

using Task_Manager.TaskStatus;

namespace Task_Manager.TaskFunctions
{
    public class TaskChoiceStatus: ITaskChoiceStatus
    {
        public void ChoiceStatus(Task task, SetStatus setStatus)
        {
            setStatus.ChoiceAction();
            string choiceStatus = Console.ReadLine();
            setStatus.Status(task, choiceStatus);
        }
    }
}
