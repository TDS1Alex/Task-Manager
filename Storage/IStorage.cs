using Microsoft.EntityFrameworkCore;
using Task_Manager.Domain;

namespace Task_Manager.Storage
{
    public interface IStorage
    {
        DbSet<Task> Task { get; set; }

        void Add_Save(Task task);
    }
}
