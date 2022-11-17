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
        public Dictionary<Executor, Task> ExecutorAndTask;
        public TeamLeader(string name, int age, Client client, Project project)
        {
            this.project = project;
            this.name = name;
            this.age = age;
            this.client = client;
            ExecutorAndTask = new Dictionary<Executor, Task> { };
        }



        public void GiveJob(Executor executor, Task task)
        {
            executor.task = task;
            executor.task.executor = executor;
            executor.task.client = client;
            ExecutorAndTask[executor] = executor.task;
        }
        
        // Дает статус В работе
        public void GiveStatus(Task task)
        {
            task.status = StatusTask.В_работе;
        }
    }
}
