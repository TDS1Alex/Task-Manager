using Task_Manager.Domain;

namespace Task_Manager.TaskStatus
{
    public interface ISetStatus
    {
        void Status(Task task, string choice);
        void ChoiceAction();
        void UserSelection(Task task);
    }
}
