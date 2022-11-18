using System;
using System.Collections.Generic;
using System.IO;
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
        int countReports;
        public Executor(string name, int age, TeamLeader teamLeader)
        {
            this.name = name;
            this.age = age;
            this.teamLeader = teamLeader;
            countReports = 0;
        }
        public void GiveReport(int HowReports)
        {
            if (task.status == StatusTask.В_работе)
            {
                Random rnd = new Random();
                var dir = new DirectoryInfo("ALLREPORTS"); // папка с файлами 
                int len = dir.GetFiles().Length;
                string[] nameFileRerort = new string[len];
                int k = 0;
                foreach (FileInfo file in dir.GetFiles())
                {
                    
                    nameFileRerort[k] = file.FullName;
                    k++;
                }
                for (int i = 0; i < HowReports - countReports; i++)
                {
                    StreamReader f = new StreamReader(nameFileRerort[rnd.Next(0, len - 1)]);
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    while (!f.EndOfStream)
                    {
                        Console.WriteLine(f.ReadLine());
                    }
                    f.Close();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                }
                if (countReports == HowReports)
                {
                    Console.WriteLine($"{name} оправлял вам отчет(ы)");
                }
                countReports = HowReports;
            }
            else if (task.status == StatusTask.На_проверке)
            {
                Console.WriteLine("К заданию еще не приступали");
            }
            else if (task.status == StatusTask.Назначена)
            {
                Console.WriteLine("К заданию еще не приступали");
            }
            else if (task.status == StatusTask.Выполнена)
            {
                Console.WriteLine("Олег, проект готов, отправил Вам в WhatsApp");
            }
        }
    }
}
