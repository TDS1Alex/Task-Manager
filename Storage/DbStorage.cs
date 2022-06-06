using Microsoft.EntityFrameworkCore;
using Task_Manager.Domain;

namespace Task_Manager.Storage
{
    public class DbStorage : DbContext, IStorage
    {
        public DbSet<Task> Task { get; set; } = null!;

        public DbStorage()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Task-Manager.db");
        }

        public void Add_Save(Task task)
        {
            using DbStorage db = new();

            db.Task.Add(task);
            db.SaveChanges();
        }
    }
}
