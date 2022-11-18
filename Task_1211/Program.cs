using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_1211
{
    class Program
    {
        static void Main(string[] args)
        {
            // 

            List<Task> tasks = new List<Task> { new Task("Создать главную страницу", new DateTime(2022, 12, 15), 0), new Task("Добавить авторизацию на сайт", new DateTime(2023, 1, 14), 0),
            new Task("Создать страницу профиля", new DateTime(2022, 11, 24), 0),  new Task("Создать базу данных для аккаунтов студентов", new DateTime(2022, 11, 24), 0),  new Task("Создать базу данных для преподавателей", new DateTime(2022, 11, 24), 0),
            new Task("Создать страницу для абитуриентов", new DateTime(2022, 11, 24), 0),  new Task("Создать функцию для слабовидящих", new DateTime(2022, 11, 24), 0),  new Task("Создать темную тему", new DateTime(2022, 11, 24), 0),
            new Task("Создать чат для студентов", new DateTime(2022, 11, 24), 0),  new Task("Исправить все баги", new DateTime(2022, 11, 24), 0) };

            Project project = new Project("Создание сайта для кфу", new DateTime(2022, 11, 24), tasks, 0);
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
            while (!command.Equals("9"))
            {
                Console.WriteLine("Команды: 1) Получить статусы задач 2) Статус проекта 3) Поменяться задачей 4) Начать проект  \n         5) Получить отчеты 6) Отправить на проверку 7) Выполнить задачу 8) Закрыть проект 9) Выйти");
                Console.WriteLine();
                Console.WriteLine("Сотрудник  Задача");
                for (int i = 0; i < executors.Count; i++)
                {
                    if (executors[i].task != null)
                    {
                        Console.WriteLine($"{executors[i].name}{string.Concat(Enumerable.Repeat(" ", 11 - executors[i].name.Length))}{executors[i].task.description}");
                    }
                    else
                    {
                        Console.WriteLine($"{executors[i].name}{string.Concat(Enumerable.Repeat(" ", 11 - executors[i].name.Length))}нету задачи");
                    }
                }
                switch (command)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Статус задачи  задача");
                        for (int i = 0; i < executors.Count; i++)
                        {
                            if (executors[i].task != null)
                            {
                                Console.WriteLine($"{executors[i].task.status}{string.Concat(Enumerable.Repeat(" ", 15 - executors[i].task.status.ToString().Length))}{executors[i].task.description}");
                            }
                        }
                        break;
                    case "2":
                        
                        Insaf.project.PrintStatus();
                        break;
                    case "3":
                        Console.Write("Какой сотрудник хочет поменятся задачей?: ");
                        string name_A = Console.ReadLine();

                        foreach (Executor emp in executors)
                        {
                            if (emp.name.Equals(name_A))
                            {
                                Insaf.AssignTask(emp);
                                break;
                            }
                        }
                        break;
                    case "4":
                        Insaf.StartWork();
                        break;
                    case "5":
                        Insaf.GetReports();
                        break;
                    case "6":
                        Insaf.SubmitForReview();
                        break;
                    case "7":
                        Insaf.MakeDone();
                        break;
                    case "8":

                        break;

                }
                command = Console.ReadLine();
                Console.Clear();
                
            }

        }
    }
}
