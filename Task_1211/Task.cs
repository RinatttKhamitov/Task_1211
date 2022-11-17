using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1211
{
    enum StatusTask
    {
        Назначена, В_работе, На_проверке,
        Выполнена

    }
    class Task
    {
        /// <summary>
        /// Описание проекта
        /// </summary>
        public string description;

        /// <summary>
        /// 
        /// </summary>
        DateTime deadlines;

        /// <summary>
        /// заказчик
        /// </summary>
        public Client client;

        /// <summary>
        /// исполнитель
        /// </summary>
        public Executor executor;
        /// <summary>
        /// Назначена, В_работе, На_проверке, Выполнена
        /// </summary>
        public StatusTask status;

        public Task(string description, DateTime deadlines, int statusInt)
        {
            this.description = description;
            this.deadlines = deadlines;
            status = (StatusTask)statusInt;
        }
        public void PrintDescription()
        {
            Console.WriteLine(description);
        }
        public void PrintDeadlines()
        {
            Console.WriteLine(deadlines);
        }
        public void TaskReports() // отчет(ы) по задаче
        { 

        }
    }
}
