using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1211
{
    enum StatusProject
    {
        Проект, Исполнение, Закрыт
    }
    class Project
    {
        /// <summary>
        /// Описание проекта
        /// </summary>
        string description;

        /// <summary>
        /// 
        /// </summary>
        DateTime deadlines;

        /// <summary>
        /// заказчик client
        /// </summary>
        Client client;

        /// <summary>
        /// тимлид team leader
        /// </summary>
        /// 
        TeamLeader teamLeader;

        /// <summary>
        /// задачи по проекту
        /// </summary>
        public List<Task> tasks;

        /// <summary>
        /// статус 1 = Project, 2 = Execution, 3 = Closed
        /// </summary>
        public StatusProject status;

        public Project(string description, DateTime deadlines, List<Task> tasks, int statusInt)
        {
            this.description = description;
            this.deadlines = deadlines;
            this.tasks = tasks;
            status = (StatusProject)statusInt;
        }
        public void PrintStatus()
        {
            int countStatusAppointed = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].status == StatusTask.Назначена)
                {
                    
                    countStatusAppointed++;
                }
            }
            if (countStatusAppointed == tasks.Count)
            {
                status = StatusProject.Исполнение;

                Console.WriteLine("Проект перешел в статус исполнение");
                Console.WriteLine($"статус проекта = {status}");
            }
            else
            {
                status = StatusProject.Проект;
                Console.WriteLine("Вы не можете объявить работу, так как есть неназначенные задания");
                Console.WriteLine($"статус проекта = {status}");
            }
        }

        public void PrintDescription()
        {
            Console.WriteLine(description);
        }
        public void PrintDeadlines()
        {
            Console.WriteLine(deadlines);
        }

    }
}
