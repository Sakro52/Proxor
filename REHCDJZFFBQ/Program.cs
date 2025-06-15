using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Курсовая
{
    class Guest
    {
        public int Id { set; get; }
        public string FullName { set; get; }
        public int PassportNumber { set; get; }
        public string Origin { set; get; }
        public int RoomNumber { set; get; }
        public string RoomType { set; get; }
        public int DaysCount { set; get; }
        public DateTime ArrivalDate { set; get; }

        public Guest(int id, string fullName, int passportNumber, string origin, int roomNumber, string roomType, int daysCount, DateTime arrivalDate)
        {
            Id = id;
            FullName = fullName;
            PassportNumber = passportNumber;
            Origin = origin;
            RoomNumber = roomNumber;
            RoomType = roomType;
            DaysCount = daysCount;
            ArrivalDate = arrivalDate;
        }

        public static Guest Add()
        {
            Console.Write("Введите ключ: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            Console.Write("Введите номер паспорта: ");
            int passportNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Откуда прибыл: ");
            string origin = Console.ReadLine();
            Console.Write("Введите номер комнаты: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип комнаты: ");
            string roomType = Console.ReadLine();
            Console.Write("Введите количество дней: ");
            int daysCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату приезда: ");
            DateTime arrivalDate = DateTime.Parse(Console.ReadLine());
            return new Guest(id, fullName, passportNumber, origin, roomNumber, roomType, daysCount, arrivalDate);
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Клиенты.txt", true))
            {
                writer.WriteLine($"{Id};{FullName};{PassportNumber};{Origin};{RoomNumber};{RoomType};{DaysCount};{ArrivalDate:yyyy-MM-dd};");
            }
        }

        public static Guest Read(string line)
        {
            string[] parts = line.Split(';');
            return new Guest(int.Parse(parts[0]), parts[1], int.Parse(parts[2]), parts[3], int.Parse(parts[4]), parts[5], int.Parse(parts[6]), DateTime.Parse(parts[7]));
        }

        public void Display()
        {
            Console.WriteLine($"Ключ: {Id}, ФИО: {FullName}, Паспорт: {PassportNumber}, Откуда: {Origin}");
            Console.WriteLine($"Номер: {RoomNumber}, Тип: {RoomType}, Дней: {DaysCount}, Дата приезда: {ArrivalDate:yyyy-MM-dd}");
        }

        public static void FilterByCity(List<Guest> guests)
        {
            Console.WriteLine("Введите название города: ");
            string city = Console.ReadLine();
            foreach (var guest in guests)
            {
                if (guest.Origin == city)
                {
                    guest.Display();
                }
            }
        }

        public void DisplaySingleRoom()
        {
            if (RoomType == "Одноместный")
            {
                Display();
            }
        }
    }
}

namespace Курсовая
{
    class Employee
    {
        public int Id { set; get; }
        public string FullName { set; get; }
        public List<int> Floors { get; } = new List<int>(7);
        public List<string> Days { get; } = new List<string>(7);

        public Employee(int id, string fullName, List<int> floors, List<string> days)
        {
            Id = id;
            FullName = fullName;
            Floors.AddRange(floors);
            Days.AddRange(days);
        }

        public static Employee Add()
        {
            Console.Write("Введите ключ: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            List<int> floors = new List<int>(7);
            for (int i = 0; i < floors.Capacity; i++)
            {
                Console.Write("Введите этаж: ");
                int floor = Convert.ToInt32(Console.ReadLine());
                floors.Add(floor > 3 ? Convert.ToInt32(Console.ReadLine()) : floor);
            }
            List<string> days = new List<string>(7);
            for (int i = 0; i < days.Capacity; i++)
            {
                Console.Write("Введите день недели: ");
                days.Add(Console.ReadLine());
            }
            return new Employee(id, fullName, floors, days);
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Служащие.txt", true))
            {
                writer.WriteLine($"{Id};{FullName};{string.Join(";", Floors)};{string.Join(";", Days)};");
            }
        }

        public static Employee Read(string line)
        {
            string[] parts = line.Split(';');
            List<int> floors = parts.Skip(2).Take(7).Select(int.Parse).ToList();
            List<string> days = parts.Skip(9).Take(7).ToList();
            return new Employee(int.Parse(parts[0]), parts[1], floors, days);
        }

        public void Display()
        {
            Console.WriteLine($"Ключ: {Id}, ФИО: {FullName}");
            foreach (var floor in Floors)
                Console.WriteLine($"Этаж: {floor}");
            foreach (var day in Days)
                Console.WriteLine($"День недели: {day}");
        }

        public void CheckCleaning()
        {
            Console.WriteLine("Введите день недели: ");
            string day = Console.ReadLine();
            Console.WriteLine("Введите этаж: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Days.Count; i++)
            {
                if (Days[i] == day && Floors[i] == floor)
                {
                    Display();
                }
            }
        }

        public static void Remove(List<Employee> employees)
        {
            Console.Write("Введите ключ служащего для удаления: ");
            int id = Convert.ToInt32(Console.ReadLine());
            employees.RemoveAll(e => e.Id == id);
            var lines = File.ReadAllLines(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Служащие.txt")
                .Where((line, index) => index + 1 != id).ToArray();
            File.WriteAllLines(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Служащие.txt", lines);
        }
    }
}

namespace Курсовая
{
    class Data
    {
        public List<Room> Rooms { get; } = new List<Room>();
        public List<Guest> Guests { get; } = new List<Guest>();
        public List<Employee> Employees { get; } = new List<Employee>();
    }
}

namespace Курсовая
{
    class Room
    {
        public int Number { set; get; }
        public int Floor { set; get; }
        public string Type { set; get; }
        public int DailyCost { set; get; }
        public List<Guest> Guests { get; } = new List<Guest>();
        public List<Employee> Employees { get; } = new List<Employee>();

        public Room(int number, int floor, string type, int dailyCost, List<Guest> guests, List<Employee> employees)
        {
            Number = number;
            Floor = floor;
            Type = type;
            DailyCost = dailyCost;
            Guests.AddRange(guests);
            Employees.AddRange(employees);
        }

        public static Room Add(List<Guest> guests, List<Employee> employees)
        {
            Console.Write("Введите номер: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите этаж: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип номера: ");
            string type = Console.ReadLine();
            Console.Write("Введите стоимость за ночь: ");
            int dailyCost = Convert.ToInt32(Console.ReadLine());
            var roomGuests = guests.Where(g => g.RoomNumber == number && g.RoomType == type).ToList();
            return new Room(number, floor, type, dailyCost, roomGuests, employees);
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Номера.txt", true))
            {
                writer.WriteLine($"{Number};{Floor};{Type};{DailyCost}");
            }
        }

        public static Room Read(string line, List<Guest> guests, List<Employee> employees)
        {
            string[] parts = line.Split(';');
            var roomGuests = guests.Where(g => g.RoomNumber == int.Parse(parts[0]) && g.RoomType == parts[2]).ToList();
            return new Room(int.Parse(parts[0]), int.Parse(parts[1]), parts[2], int.Parse(parts[3]), roomGuests, employees);
        }

        public void Display()
        {
            Console.WriteLine($"Номер: {Number}, Этаж: {Floor}, Тип: {Type}, Стоимость: {DailyCost}");
        }

        public int CalculateCost()
        {
            switch (Type)
            {
                case "Одноместный":
                    return DailyCost;
                case "Двухместный":
                    return DailyCost / 2;
                default:
                    return DailyCost / 3;
            }
        }

        public void DisplayEmpty()
        {
            if (Guests.Count == 0)
            {
                Display();
            }
        }
    }
}

namespace Курсовая
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();
            List<Employee> employees = new List<Employee>();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("ПЕРВОЕ МЕНЮ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[1] Загрузить данные");
                Console.WriteLine("[2] Добавить клиента");
                Console.WriteLine("[3] Добавить служащего");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[4] Выйти из первого меню");
                Console.WriteLine("[5] Сохранить и выйти");
                Console.ResetColor();

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        try
                        {
                            Console.Clear();
                            using (StreamReader reader = new StreamReader(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Служащие.txt"))
                            {
                                while (reader.Peek() >= 0)
                                    employees.Add(Employee.Read(reader.ReadLine()));
                            }
                            using (StreamReader reader = new StreamReader(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Клиенты.txt"))
                            {
                                while (reader.Peek() >= 0)
                                    guests.Add(Guest.Read(reader.ReadLine()));
                            }
                            using (StreamReader reader = new StreamReader(@"C:\Users\andre\OneDrive\Документы\GitHub\Proect\Номера.txt"))
                            {
                                while (reader.Peek() >= 0)
                                    rooms.Add(Room.Read(reader.ReadLine(), guests, employees));
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Данные успешно загружены");
                            Console.ResetColor();
                            Console.Write("Продолжить? ");
                            if (Console.ReadLine().ToLower() == "нет")
                                isRunning = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ошибка загрузки данных");
                            Console.ResetColor();
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.Clear();
                            guests.Add(Guest.Add());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Клиент успешно добавлен");
                            Console.ResetColor();
                            Console.Write("Продолжить? ");
                            if (Console.ReadLine().ToLower() == "нет")
                                isRunning = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ошибка, попробуйте снова");
                            Console.ResetColor();
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.Clear();
                            employees.Add(Employee.Add());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Служащий успешно добавлен");
                            Console.ResetColor();
                            Console.Write("Продолжить? ");
                            if (Console.ReadLine().ToLower() == "нет")
                                isRunning = false;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Ошибка, попробуйте снова");
                            Console.ResetColor();
                        }
                        break;
                    case '4':
                        isRunning = false;
                        break;
                    case '5':
                        foreach (var guest in guests)
                            guest.Save();
                        foreach (var employee in employees)
                            employee.Save();
                        return;
                }
            }

            bool isMainRunning = true;
            while (isMainRunning)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("ГЛАВНОЕ МЕНЮ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[1] Номера");
                Console.WriteLine("[2] Клиенты");
                Console.WriteLine("[3] Служащие");
                Console.WriteLine("[4] Выход");
                Console.ResetColor();

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        bool isRoomRunning = true;
                        while (isRoomRunning)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[1] Показать информацию о номерах");
                            Console.WriteLine("[2] Стоимость номера");
                            Console.WriteLine("[3] Свободные номера");
                            Console.WriteLine("[4] Общая выручка");
                            Console.WriteLine("[5] Вернуться в главное меню");
                            Console.ResetColor();

                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var room in rooms)
                                            room.Display();
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Информация о номерах выведена");
                                        Console.ResetColor();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isRoomRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка");
                                    }
                                    break;
                                case '2':
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите номер комнаты: ");
                                        int n = Convert.ToInt32(Console.ReadLine());
                                        foreach (var room in rooms)
                                        {
                                            if (room.Number == n)
                                                Console.WriteLine($"Стоимость номера {room.Number} составляет {room.CalculateCost()} руб. за место");
                                        }
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isRoomRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка");
                                    }
                                    break;
                                case '3':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var room in rooms)
                                            room.DisplayEmpty();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isRoomRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка");
                                    }
                                    break;
                                case '4':
                                    try
                                    {
                                        Console.Clear();
                                        int totalCost = rooms.Where(r => r.Guests.Count > 0).Sum(r => r.CalculateCost());
                                        int totalDays = guests.Sum(g => g.DaysCount);
                                        Console.WriteLine($"Общая выручка: {totalCost * totalDays} руб.");
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isRoomRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка");
                                    }
                                    break;
                                case '5':
                                    isRoomRunning = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Неверный ввод, попробуйте снова");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        break;
                    case '2':
                        bool isGuestRunning = true;
                        while (isGuestRunning)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[1] Показать информацию о клиентах");
                            Console.WriteLine("[2] Клиенты из города");
                            Console.WriteLine("[3] Клиенты в одноместных номерах");
                            Console.WriteLine("[4] Вернуться в главное меню");
                            Console.ResetColor();

                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var guest in guests)
                                            guest.Display();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isGuestRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '2':
                                    try
                                    {
                                        Console.Clear();
                                        Guest.FilterByCity(guests);
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isGuestRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '3':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var guest in guests)
                                            guest.DisplaySingleRoom();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isGuestRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '4':
                                    isGuestRunning = false;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Неверный ввод, попробуйте снова");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                        break;
                    case '3':
                        bool isEmployeeRunning = true;
                        while (isEmployeeRunning)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("[1] Показать информацию о служащих");
                            Console.WriteLine("[2] Расписание уборки");
                            Console.WriteLine("[3] Нанять служащего");
                            Console.WriteLine("[4] Уволить служащего");
                            Console.WriteLine("[5] Вернуться в главное меню");
                            Console.ResetColor();

                            switch (Console.ReadKey(true).KeyChar)
                            {
                                case '1':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var employee in employees)
                                            employee.Display();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isEmployeeRunning = false;
                                    }
                                    catch
                                    {
                                        Console.ReadLine();
                                    }
                                    break;
                                case '2':
                                    try
                                    {
                                        Console.Clear();
                                        foreach (var employee in employees)
                                            employee.CheckCleaning();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isEmployeeRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '3':
                                    try
                                    {
                                        Console.Clear();
                                        employees.Add(Employee.Add());
                                        employees.Last().Save();
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isEmployeeRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '4':
                                    try
                                    {
                                        Console.Clear();
                                        Employee.Remove(employees);
                                        Console.Write("Продолжить? ");
                                        if (Console.ReadLine().ToLower() == "нет")
                                            isEmployeeRunning = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Ошибка, попробуйте снова");
                                    }
                                    break;
                                case '5':
                                    isEmployeeRunning = false;
                                    break;
                                default:
                                    Console.WriteLine("Неверный ввод, попробуйте снова");
                                    break;
                            }
                        }
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("Неверный ввод, попробуйте снова");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}