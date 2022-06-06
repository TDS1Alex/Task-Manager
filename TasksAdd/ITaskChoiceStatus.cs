using Task_Manager.TaskStatus;
using Task_Manager.Domain;

namespace Task_Manager.TasksAdd
{
    public interface ITaskChoiceStatus
    {
        void ChoiceStatus(Task task, ISetStatus setStatus);
    }
}
