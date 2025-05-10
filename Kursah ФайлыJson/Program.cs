using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Kursah
{
    internal class Program
    {
        static List<Newspaper> newspaperList = new List<Newspaper>();
        static List<PostOffice> postOffices = new List<PostOffice>();

        static string newspaperFile = "newspapers.json";
        static string postOfficeFile = "postoffices.json";

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Система учёта газет";

            LoadData(); // Загружаем данные при старте

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
                    case "5": RemoveNewspaper(); break;
                    case "6": running = false; break;
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
            WriteCenter("║ 5.  Удалить газету                     ║");
            WriteCenter("║ 6.  Выход                              ║");
            WriteCenter("╚════════════════════════════════════════╝");
            Console.WriteLine();
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
            SaveData(); // Сохраняем изменения
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

                SaveData(); // Сохраняем изменения
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
                SaveData(); // Сохраняем изменения
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
                SaveData(); // Сохраняем изменения
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
            File.WriteAllText(newspaperFile, JsonSerializer.Serialize(newspaperList, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText(postOfficeFile, JsonSerializer.Serialize(postOffices, new JsonSerializerOptions { WriteIndented = true }));
        }

        static void LoadData()
        {
            if (File.Exists(newspaperFile))
            {
                string json = File.ReadAllText(newspaperFile);
                newspaperList = JsonSerializer.Deserialize<List<Newspaper>>(json);
            }

            if (File.Exists(postOfficeFile))
            {
                string json = File.ReadAllText(postOfficeFile);
                postOffices = JsonSerializer.Deserialize<List<PostOffice>>(json);
            }
        }
    }
}
