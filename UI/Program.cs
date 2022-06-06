using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Task_Manager.TasksAdd;
using Task_Manager.TaskStatus;
using Task_Manager.Storage;
using Task_Manager.TasksReceiving;
using Task_Manager.StartTaskManager;

namespace Task_Manager.UI
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<IStartManager>().Start();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                 .ConfigureServices(services =>
                 {
                     //TasksAdd
                     services.AddScoped<ITaskAdd, TaskAdd>();
                     services.AddScoped<ITaskChoiceStatus, TaskChoiceStatus>();
                     services.AddScoped<ITaskDateCreated, TaskDateCreated>();

                     //TasksReceiving
                     services.AddScoped<ITaskReceiving, TaskReceiving>();
                     services.AddScoped<ITaskList, TaskList>();

                     //TaskStatus
                     services.AddScoped<ISetStatus, SetStatus>();

                     //Storage
                     services.AddScoped<IStorage, DbStorage>();

                     //UI
                     services.AddScoped<IManager, Manager>();
                     services.AddScoped<ITaskDescription, TaskDescription>();

                     //StartTaskManager
                     services.AddScoped<IStartManager, StartManager>();
                 });
        }
    }
}
