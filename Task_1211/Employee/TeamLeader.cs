using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1211
{
    /// <summary>
    /// тимлид
    /// </summary>
    class TeamLeader : Employee
    {
        Client client;
        public Project project;
        public Dictionary<Executor, Task> executorAndTask;
        public TeamLeader(string name, int age, Client client, Project project)
        {
            this.project = project;
            this.name = name;
            this.age = age;
            this.client = client;
            executorAndTask = new Dictionary<Executor, Task> { };
        }

        public void GiveJob(Executor executor, Task task)
        {
            executor.task = task;
            executor.task.executor = executor;
            executor.task.client = client;
            executorAndTask[executor] = executor.task;
        }

        // Дает статус В работе
        public void GiveStatus(Task task)
        {
            task.status = StatusTask.В_работе;
        }

        public void AssignTask(Executor executor)
        {
            Console.WriteLine("Что выберет тимлид? 1) Отклонить 2) Удалить задание 3) Дать задание другому ");
            string comm = Console.ReadLine();
            switch (comm)
            {
                case "1":
                    {
                        Console.WriteLine("Тимлид отклонил запрос");
                        break;
                    }
                case "2":
                    {
                        project.tasks.Remove(executor.task);
                        executorAndTask[executor] = null;
                        executor.task = null;

                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Введи имя сотрудника с кем поменять: ");
                        string name_B = Console.ReadLine();

                        foreach (var emp in executorAndTask)
                        {
                            if (emp.Key.name.Equals(name_B))
                            {
                                Task tempTask = emp.Key.task;
                                emp.Key.task = executor.task;
                                executor.task = tempTask;
                                break;
                            }
                        }
                        break;

                    }
            }

        }
        public void GetReports()
        {
            foreach (var executor in executorAndTask)
            {
                if (executor.Key.task != null)
                {
                    int day = (DateTime.Now.Date - executor.Key.task.deadlines.Date).Days;
                    Console.WriteLine(day);
                }
            }
        }
    }
}
