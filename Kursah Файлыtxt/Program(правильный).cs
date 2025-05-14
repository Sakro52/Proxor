using Kursah;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

internal class Program
{
    static List<Newspaper> newspaperList = new List<Newspaper>();
    static List<PostOffice> postOffices = new List<PostOffice>();

    static string newspaperFile = "newspapers.txt";
    static string postOfficeFile = "postoffices.txt";

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "Система учёта газет";

        LoadData();

        bool running = true;

        while (running)
        {
            Console.Clear();
            ShowMenu();

            Console.Write("→ Ваш выбор: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1": AddNewspaper(); break;
                case "2": AddNewspaperToPostOffice(); break;
                case "3": ShowAllNewspapers(); break;
                case "4": EditNewspaper(); break;
                case "5": CalculateTotalCostInPostOffice(); break;
                case "6": RemoveNewspaper(); break;
                case "7": running = false; break;
                default:
                    WriteCenter("Неверный выбор. Нажмите Enter...");
                    Console.ReadLine();
                    break;
            }
        }

        WriteCenter("\nПрограмма завершена. Нажмите любую клавишу...");
        Console.ReadKey();
    }

    static void ShowMenu()
    {
        WriteCenter("╔════════════════════════════════════════╗");
        WriteCenter("║         СИСТЕМА УЧЁТА ГАЗЕТ            ║");
        WriteCenter("╠════════════════════════════════════════╣");
        WriteCenter("║ 1.  Добавить газету                    ║");
        WriteCenter("║ 2.  Добавить газету в отделение        ║");
        WriteCenter("║ 3.  Показать все газеты                ║");
        WriteCenter("║ 4.  Редактирование газеты              ║");
        WriteCenter("║ 5.  Посчитать стоимость в отделении    ║");
        WriteCenter("║ 6.  Удалить газету                     ║");
        WriteCenter("║ 7.  Выход                              ║");
        WriteCenter("╚════════════════════════════════════════╝");
        Console.WriteLine();
    }

    static void CalculateTotalCostInPostOffice()
    {
        WriteCenter("=== СУММАРНАЯ СТОИМОСТЬ ГАЗЕТ В ОТДЕЛЕНИИ ===");
        if (postOffices.Count == 0)
        {
            WriteCenter("Нет отделений для расчёта.");
            WriteCenter("Нажмите Enter...");
            Console.ReadLine();
            return;
        }

        WriteCenter("Список отделений:");
        for (int i = 0; i < postOffices.Count; i++)
        {
            WriteCenter($"{i + 1}. Отделение №{postOffices[i].Number}, Адрес: {postOffices[i].Address}");
        }

        Console.Write("Выберите отделение (введите номер): ");
        if (!int.TryParse(Console.ReadLine(), out int postOfficeIndex) || postOfficeIndex < 1 || postOfficeIndex > postOffices.Count)
        {
            WriteCenter("Неверный выбор отделения.");
            WriteCenter("Нажмите Enter...");
            Console.ReadLine();
            return;
        }

        var selectedPostOffice = postOffices[postOfficeIndex - 1];
        if (selectedPostOffice.Newspapers.Count == 0)
        {
            WriteCenter($"В отделении №{selectedPostOffice.Number} нет газет.");
            WriteCenter("Нажмите Enter...");
            Console.ReadLine();
            return;
        }

        decimal totalCost = selectedPostOffice.Newspapers.Sum(newspaper => newspaper.Price);
        WriteCenter($"Суммарная стоимость газет в отделении №{selectedPostOffice.Number}: {totalCost} руб.");
        WriteCenter("Нажмите Enter...");
        Console.ReadLine();
    }

    static void AddNewspaper()
    {
        WriteCenter("=== ДОБАВЛЕНИЕ ГАЗЕТЫ ===");
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
        WriteCenter(" Газета добавлена. Нажмите Enter...");
        Console.ReadLine();
    }

    static void EditNewspaper()
    {
        ShowAllNewspapers();
        Console.Write("\nВведите номер газеты для редактирования: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
        {
            Newspaper n = newspaperList[i - 1];
            WriteCenter("=== РЕДАКТИРОВАНИЕ ===");

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
            WriteCenter(" Газета обновлена.");
        }
        else
        {
            WriteCenter(" Неверный номер.");
        }

        Console.WriteLine("\nНажмите Enter...");
        Console.ReadLine();
    }

    static void ShowAllNewspapers()
    {
        WriteCenter("=== СПИСОК ВСЕХ ГАЗЕТ ===\n");

        if (newspaperList.Count == 0)
        {
            WriteCenter(" Газет нет.");
        }
        else
        {
            for (int i = 0; i < newspaperList.Count; i++)
            {
                WriteCenter($"[{i + 1}]");
                newspaperList[i].Print();
                Console.WriteLine();
            }
        }

        WriteCenter("Нажмите Enter для продолжения...");
        Console.ReadLine();
    }

    static void RemoveNewspaper()
    {
        ShowAllNewspapers();
        Console.Write("\nВведите номер газеты для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
        {
            newspaperList.RemoveAt(i - 1);
            SaveData();
            WriteCenter(" Газета удалена.");
        }
        else
        {
            WriteCenter(" Неверный номер.");
        }

        Console.WriteLine("\nНажмите Enter...");
        Console.ReadLine();
    }

    static void AddNewspaperToPostOffice()
    {
        WriteCenter("=== ДОБАВЛЕНИЕ ГАЗЕТЫ В ОТДЕЛЕНИЕ ===");
        Console.Write("Введите номер отделения: ");
        int.TryParse(Console.ReadLine(), out int num);

        PostOffice po = postOffices.Find(x => x.Number == num);
        if (po == null)
        {
            po = new PostOffice();
            po.Number = num;
            Console.Write("Введите адрес отделения: ");
            po.Address = Console.ReadLine();
            postOffices.Add(po);
        }

        ShowAllNewspapers();
        Console.Write("Введите номер газеты: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= newspaperList.Count)
        {
            po.Newspapers.Add(newspaperList[i - 1]);
            SaveData();
            WriteCenter(" Газета добавлена в отделение.");
        }
        else
        {
            WriteCenter(" Неверный номер.");
        }

        Console.WriteLine();
        po.Print();

        WriteCenter("Нажмите Enter...");
        Console.ReadLine();
    }

    static void WriteCenter(string text)
    {
        int windowWidth = Console.WindowWidth;
        int textLength = text.Length;
        int leftPadding = Math.Max((windowWidth - textLength) / 2, 0);
        Console.WriteLine(new string(' ', leftPadding) + text);
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