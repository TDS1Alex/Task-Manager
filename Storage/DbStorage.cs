using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Task_Manager.Storage
{
    public class DbStorage : DbContext
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

    }
}
