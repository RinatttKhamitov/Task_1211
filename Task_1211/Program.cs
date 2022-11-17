using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1211
{
    class Program
    {
        static void Main(string[] args)
        {
            // 

            List<Task> tasks = new List<Task> { new Task("1", new DateTime(2022, 11, 24), 0), new Task("2", new DateTime(2022, 11, 24), 0),
            new Task("3", new DateTime(2022, 11, 24), 0),  new Task("4", new DateTime(2022, 11, 24), 0),  new Task("5", new DateTime(2022, 11, 24), 0),
            new Task("6", new DateTime(2022, 11, 24), 0),  new Task("7", new DateTime(2022, 11, 24), 0),  new Task("8", new DateTime(2022, 11, 24), 0),
            new Task("9", new DateTime(2022, 11, 24), 0),  new Task("10", new DateTime(2022, 11, 24), 0) };

            Project project = new Project("", new DateTime(2022, 11, 24), tasks, 0);
            Client Oleg = new Client("Олег", 24, project, tasks);
            TeamLeader Insaf = new TeamLeader("Инсаф", 29, Oleg, project);
            Executor Vlad = new Executor("Влад",  21, Insaf);
            Executor Rinat = new Executor("Ринат", 24, Insaf);
            Executor Marat = new Executor("Марат", 24, Insaf);
            Executor Nikita = new Executor("Никита", 27, Insaf);
            Executor Karim = new Executor("Карим", 22, Insaf);
            Executor Kirill = new Executor("Кирилл", 23, Insaf);
            Executor Catherine = new Executor("Екатерина", 23, Insaf);
            Executor Artem = new Executor("Артем", 22, Insaf);
            Executor Diana = new Executor("Диана", 21, Insaf);
            Executor Ravil = new Executor("Равиль", 22, Insaf);
            List<Executor> executors = new List<Executor> { Vlad, Rinat, Marat, Nikita, Karim, Kirill, Catherine, Artem, Diana, Ravil };


            for (int i = 0; i < 10; i++) 
            {
                Insaf.GiveJob(executors[i], Insaf.project.tasks[i]);
            }

            string command = "";
            while (!command.Equals(4))
            {
                Console.WriteLine("Команды: 1) Получить статусы задач, 2) Статус проекта ");
                Console.WriteLine();
                Console.WriteLine("Сотрудник  Задача");
                for (int i = 0; i < executors.Count; i++)
                {
                    Console.WriteLine($"{executors[i].name}{string.Concat(Enumerable.Repeat(" ", 11 - executors[i].name.Length))}{executors[i].task.description}");
                }
                switch (command)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Сотрудник  Статус задачи");
                        for (int i = 0; i < executors.Count; i++)
                        {
                            Console.WriteLine($"{executors[i].name}{string.Concat(Enumerable.Repeat(" ", 11 - executors[i].name.Length))}{executors[i].task.status}");
                        }
                        break;
                    case "2":
                        
                        Insaf.project.PrintStatus();
                        break;
                }
                command = Console.ReadLine();
                Console.Clear();
                
            }

        }
    }
}
