using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Task_Manager.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие и выбор действий
            MenuInformer menuInformer = new();
            Manager manager = new();

            menuInformer.Hello();
            manager.MenuChoice();
        }
    }
}
