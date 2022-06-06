using Task_Manager.Domain;

namespace Task_Manager.UI
{
    public interface ITaskDescription
    {
        void Description(string name, string description, string status, int time);
        void SetDescription(Task task);
    }
}
