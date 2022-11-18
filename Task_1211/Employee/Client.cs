using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1211
{
    /// <summary>
    /// заказчик
    /// </summary>
    class Client : Employee
    {
        public List<Task> tasks;
        Project project;
        public Client(string name, int age, Project project, List<Task> tasks)
        {
            this.name = name;
            this.age = age;
            this.tasks = tasks;
            this.project = project;
        }
        

        public void СloseProject()
        {
            project.PrintStatus();
            if (project.status == StatusProject.Закрыт)
            {
                Console.WriteLine("Проект закрыт");
            }
        }
    }
}
