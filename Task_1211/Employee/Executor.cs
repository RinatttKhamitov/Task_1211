using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1211
{
    /// <summary>
    /// исполнитель
    /// </summary>
    class Executor : Employee
    {
        public Task task;
        public TeamLeader teamLeader;
        public Executor(string name, int age, TeamLeader teamLeader)
        {
            this.name = name;
            this.age = age;
            this.teamLeader = teamLeader;
        }
    }
}
