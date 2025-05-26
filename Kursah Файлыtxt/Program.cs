using Kursah;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Курсовая
{
    internal class Program
    {
        static List<Newspaper> newspaperList = new List<Newspaper>();
        static List<PostOffice> postOffices = new List<PostOffice>();
        static string newspaperFile = "newspapers.txt";
        static string postOfficeFile = "postoffices.txt";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Система учёта газет";
            bool flag = true;

            // Первое меню: загрузка и добавление данных
            while (flag)
            {
                Console.Clear();
                ShowFirstMenu();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        try
                        {
                            Console.Clear();
                            LoadData();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Считывание удалось");
                            Console.ResetColor();
                            Console.Write("Хотите продолжить? (Да/Нет): ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "нет")
                                flag = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Считывание не удалось");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.Clear();
                            AddNewspaper();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Новая газета успешно добавлена");
                            Console.ResetColor();
                            Console.Write("Хотите продолжить выбор из первого меню? (Да/Нет): ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "нет")
                                flag = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Произошла ошибка, попробуйте еще раз");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.Clear();
                            AddPostOffice();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Новое отделение успешно добавлено");
                            Console.ResetColor();
                            Console.Write("Хотите продолжить выбор из первого меню? (Да/Нет): ");
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "нет")
                                flag = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Произошла ошибка, попробуйте еще раз");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        flag = false;
                        break;
                    case '5':
                        SaveData();
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка, попробуйте еще раз");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }

            // Главное меню
            bool flagMain = true;
            while (flagMain)
            {
                Console.Clear();
                ShowMainMenu();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        bool flagNewspapers = true;
                        while (flagNewspapers)
                        {
                            Console.Clear();
                            ShowNewspapersMenu();
                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    try
                                    {
                                        Console.Clear();
                                        ShowAllNewspapers();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Информация успешно выведена");
                                        Console.ResetColor();
                                        Console.Write("Хотите продолжить? (Да/Нет): ");
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "нет")
                                            flagNewspapers = false;
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ошибка, попробуйте еще раз");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '2':
                                    try
                                    {
                                        Console.Clear();
                                        EditNewspaper();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Газета успешно отредактирована");
                                        Console.ResetColor();
                                        Console.Write("Хотите продолжить? (Да/Нет): ");
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "нет")
                                            flagNewspapers = false;
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ошибка, попробуйте еще раз");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '3':
                                    try
                                    {
                                        Console.Clear();
                                        RemoveNewspaper();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Газета успешно удалена");
                                        Console.ResetColor();
                                        Console.Write("Хотите продолжить? (Да/Нет): ");
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "нет")
                                            flagNewspapers = false;
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ошибка, попробуйте еще раз");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '4':
                                    flagNewspapers = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ошибка, попробуйте еще раз");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case '2':
                        bool flagPostOffices = true;
                        while (flagPostOffices)
                        {
                            Console.Clear();
                            ShowPostOfficesMenu();
                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    try
                                    {
                                        Console.Clear();
                                        AddNewspaperToPostOffice();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Газета успешно добавлена в отделение");
                                        Console.ResetColor();
                                        Console.Write("Хотите продолжить? (Да/Нет): ");
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "нет")
                                            flagPostOffices = false;
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ошибка, попробуйте еще раз");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '2':
                                    try
                                    {
                                        Console.Clear();
                                        CalculateTotalCostInPostOffice();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Стоимость успешно рассчитана");
                                        Console.ResetColor();
                                        Console.Write("Хотите продолжить? (Да/Нет): ");
                                        string answer = Console.ReadLine();
                                        if (answer.ToLower() == "нет")
                                            flagPostOffices = false;
                                    }
                                    catch
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ошибка, попробуйте еще раз");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                case '3':
                                    flagPostOffices = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ошибка, попробуйте еще раз");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;
                    case '3':
                        SaveData();
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка, попробуйте еще раз");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowFirstMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ПЕРВОЕ МЕНЮ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Считывание данных");
            Console.WriteLine("[2] Добавление газеты");
            Console.WriteLine("[3] Добавление отделения");
            Console.WriteLine("[4] Выход из первого меню");
            Console.WriteLine("[5] Выход из программы для сохранения данных");
            Console.ResetColor();
        }

        static void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ГЛАВНОЕ МЕНЮ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Газеты");
            Console.WriteLine("[2] Отделения");
            Console.WriteLine("[3] Выход из программы");
            Console.ResetColor();
        }

        static void ShowNewspapersMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Вывод информации о газетах");
            Console.WriteLine("[2] Редактировать газету");
            Console.WriteLine("[3] Удалить газету");
            Console.WriteLine("[4] Выход в главное меню");
            Console.ResetColor();
        }

        static void ShowPostOfficesMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Добавить газету в отделение");
            Console.WriteLine("[2] Посчитать стоимость в отделении");
            Console.WriteLine("[3] Выход в главное меню");
            Console.ResetColor();
        }

        static void AddNewspaper()
        {
            Console.WriteLine("=== ДОБАВЛЕНИЕ ГАЗЕТЫ ===");
            Newspaper n = new Newspaper();
            Console.Write("Название: ");
            n.Name = Console.ReadLine();
            Console.Write("Индекс: ");
            n.Index = Console.ReadLine();
            Console.Write("ФИО редактора: ");
            n.Editor = Console.ReadLine();
            Console.Write("Цена (в руб.): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
                n.Price = price;
            else
                n.Price = 0;
            newspaperList.Add(n);
            SaveData();
        }

        static void AddPostOffice()
        {
            Console.WriteLine("=== ДОБАВЛЕНИЕ ОТДЕЛЕНИЯ ===");
            PostOffice po = new PostOffice();
            Console.Write("Номер отделения: ");
            if (int.TryParse(Console.ReadLine(), out int number))
                po.Number = number;
            Console.Write("Адрес отделения: ");
            po.Address = Console.ReadLine();
            po.Newspapers = new List<Newspaper>();
            postOffices.Add(po);
            SaveData();
        }

        static void EditNewspaper()
        {
            ShowAllNewspapers();
            Console.Write("\nВведите номер газеты для редактирования: ");
            if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
            {
                Newspaper n = newspaperList[i - 1];
                Console.WriteLine("=== РЕДАКТИРОВАНИЕ ===");
                Console.Write("Новое название (Enter — оставить): ");
                string input = Console.ReadLine();
                if (input != "") n.Name = input;
                Console.Write("Новый индекс: ");
                input = Console.ReadLine();
                if (input != "") n.Index = input;
                Console.Write("Новый редактор: ");
                input = Console.ReadLine();
                if (input != "") n.Editor = input;
                Console.Write("Новая цена: ");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal p)) n.Price = p;
                SaveData();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный номер.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        static void ShowAllNewspapers()
        {
            Console.WriteLine("=== СПИСОК ВСЕХ ГАЗЕТ ===\n");
            if (newspaperList.Count == 0)
            {
                Console.WriteLine("Газет нет.");
            }
            else
            {
                for (int i = 0; i < newspaperList.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}]");
                    newspaperList[i].Print();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        static void RemoveNewspaper()
        {
            ShowAllNewspapers();
            Console.Write("\nВведите номер газеты для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
            {
                newspaperList.RemoveAt(i - 1);
                SaveData();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный номер.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        static void AddNewspaperToPostOffice()
        {
            Console.WriteLine("=== ДОБАВЛЕНИЕ ГАЗЕТЫ В ОТДЕЛЕНИЕ ===");
            Console.Write("Введите номер отделения: ");
            int.TryParse(Console.ReadLine(), out int num);

            PostOffice po = postOffices.Find(x => x.Number == num);
            if (po == null)
            {
                po = new PostOffice();
                po.Number = num;
                Console.Write("Введите адрес отделения: ");
                po.Address = Console.ReadLine();
                po.Newspapers = new List<Newspaper>();
                postOffices.Add(po);
            }

            ShowAllNewspapers();
            Console.Write("Введите номер газеты: ");
            if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
            {
                po.Newspapers.Add(newspaperList[i - 1]);
                SaveData();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный номер.");
                Console.ResetColor();
                Console.ReadKey();
            }
            Console.WriteLine();
            po.Print();
        }

        static void CalculateTotalCostInPostOffice()
        {
            Console.WriteLine("=== СУММАРНАЯ СТОИМОСТЬ ГАЗЕТ В ОТДЕЛЕНИИ ===");
            if (postOffices.Count == 0)
            {
                Console.WriteLine("Нет отделений для расчёта.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Список отделений:");
            for (int i = 0; i < postOffices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Отделение №{postOffices[i].Number}, Адрес: {postOffices[i].Address}");
            }

            Console.Write("Выберите отделение (введите номер): ");
            if (!int.TryParse(Console.ReadLine(), out int postOfficeIndex) || postOfficeIndex < 1 || postOfficeIndex > postOffices.Count)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный выбор отделения.");
                Console.ResetColor();
                Console.ReadKey();
                return;
            }

            var selectedPostOffice = postOffices[postOfficeIndex - 1];
            if (selectedPostOffice.Newspapers.Count == 0)
            {
                Console.WriteLine($"В отделении №{selectedPostOffice.Number} нет газет.");
                Console.ReadKey();
                return;
            }

            decimal totalCost = selectedPostOffice.Newspapers.Sum(newspaper => newspaper.Price);
            Console.WriteLine($"Суммарная стоимость газет в отделении №{selectedPostOffice.Number}: {totalCost} руб.");
            Console.ReadKey();
        }

        static void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(newspaperFile))
            {
                foreach (var newspaper in newspaperList)
                {
                    sw.WriteLine($"{newspaper.Name},{newspaper.Index},{newspaper.Editor},{newspaper.Price}");
                }
            }

            using (StreamWriter sw = new StreamWriter(postOfficeFile))
            {
                foreach (var postOffice in postOffices)
                {
                    sw.WriteLine($"{postOffice.Number},{postOffice.Address}");
                    foreach (var newspaper in postOffice.Newspapers)
                    {
                        sw.WriteLine($"  {newspaper.Name},{newspaper.Index},{newspaper.Editor},{newspaper.Price}");
                    }
                }
            }
        }

        static void LoadData()
        {
            if (File.Exists(newspaperFile))
            {
                using (StreamReader sr = new StreamReader(newspaperFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        var newspaper = new Newspaper
                        {
                            Name = parts[0],
                            Index = parts[1],
                            Editor = parts[2],
                            Price = decimal.TryParse(parts[3], out decimal price) ? price : 0
                        };
                        newspaperList.Add(newspaper);
                    }
                }
            }

            if (File.Exists(postOfficeFile))
            {
                using (StreamReader sr = new StreamReader(postOfficeFile))
                {
                    string line;
                    PostOffice postOffice = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("  "))
                        {
                            var parts = line.Trim().Split(',');
                            var newspaper = new Newspaper
                            {
                                Name = parts[0],
                                Index = parts[1],
                                Editor = parts[2],
                                Price = decimal.TryParse(parts[3], out decimal price) ? price : 0
                            };
                            postOffice.Newspapers.Add(newspaper);
                        }
                        else
                        {
                            var parts = line.Split(',');
                            postOffice = new PostOffice
                            {
                                Number = int.Parse(parts[0]),
                                Address = parts[1],
                                Newspapers = new List<Newspaper>()
                            };
                            postOffices.Add(postOffice);
                        }
                    }
                }
            }
        }
    }
}