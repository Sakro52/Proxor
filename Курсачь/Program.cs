using System;
using System.Collections.Generic;
using System.Linq;

class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Quantity { get; set; } // в кг
    public DateTime SupplyDate { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Ingredient(int id, string name, double quantity, DateTime supplyDate, DateTime expiryDate)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        SupplyDate = supplyDate;
        ExpiryDate = expiryDate;
    }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Weight { get; set; } // в кг
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int ProductionVolume { get; set; }
    public double Price { get; set; }
    public List<Ingredient> Ingredients { get; set; }

    public Product(int id, string name, double weight, DateTime productionDate, DateTime expiryDate, int productionVolume, double price)
    {
        Id = id;
        Name = name;
        Weight = weight;
        ProductionDate = productionDate;
        ExpiryDate = expiryDate;
        ProductionVolume = productionVolume;
        Price = price;
        Ingredients = new List<Ingredient>();
    }
}

class Bakery
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ProductionDate { get; set; }
    public List<Product> Products { get; set; }

    public Bakery(int id, string name, DateTime productionDate)
    {
        Id = id;
        Name = name;
        ProductionDate = productionDate;
        Products = new List<Product>();
    }
}

class Program
{
    static List<Bakery> bakeries = new List<Bakery>();
    static int bakeryIdCounter = 1;
    static int productIdCounter = 1;
    static int ingredientIdCounter = 1;

    static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void DisplayMenu()
    {
        Console.Clear();
        SetConsoleColor(ConsoleColor.Cyan);
        Console.WriteLine("=====================================");
        Console.WriteLine("  СИСТЕМА УЧЁТА ХЛЕБОЗАВОДОВ  ");
        Console.WriteLine("=====================================");
        SetConsoleColor(ConsoleColor.DarkYellow); // Коричневый оттенок
        Console.WriteLine("1. Добавить хлебозавод");
        Console.WriteLine("2. Добавить изделие");
        Console.WriteLine("3. Удалить изделие");
        Console.WriteLine("4. Показать изделия хлебозавода");
        Console.WriteLine("5. Показать суммарную стоимость изделий");
        Console.WriteLine("6. Показать изделия с просроченными ингредиентами");
        Console.WriteLine("7. Отсортировать хлебозаводы по объему производства");
        Console.WriteLine("8. Показать изделие с максимальным количеством ингредиентов");
        Console.WriteLine("9. Показать изделие с максимальной прибылью");
        Console.WriteLine("10. Показать все данные");
        Console.WriteLine("11. Выход");
        SetConsoleColor(ConsoleColor.White);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            DisplayMenu();
            Console.Write("Выберите действие: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Неверный ввод!");
                Console.WriteLine("Нажмите Enter...");
                Console.ReadLine();
                continue;
            }

            switch (choice)
            {
                case 1: // Добавить хлебозавод
                    Console.Write("Введите название хлебозавода: ");
                    string bakeryName = Console.ReadLine();
                    Console.Write("Введите дату производства (гггг-мм-дд): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime bakeryProdDate))
                    {
                        bakeries.Add(new Bakery(bakeryIdCounter++, bakeryName, bakeryProdDate));
                        Console.WriteLine("Хлебозавод добавлен!");
                    }
                    else
                    {
                        Console.WriteLine("Неверный формат даты!");
                    }
                    break;

                case 2: // Добавить изделие
                    Console.Write("Введите название хлебозавода: ");
                    string bakeryNameForProduct = Console.ReadLine();
                    Bakery bakery = bakeries.Find(b => b.Name == bakeryNameForProduct);
                    if (bakery == null)
                    {
                        Console.WriteLine("Хлебозавод не найден!");
                        break;
                    }
                    Console.Write("Введите название изделия: ");
                    string productName = Console.ReadLine();
                    Console.Write("Введите вес изделия (кг): ");
                    if (!double.TryParse(Console.ReadLine(), out double weight))
                    {
                        Console.WriteLine("Неверный вес!");
                        break;
                    }
                    Console.Write("Введите дату производства (гггг-мм-дд): ");
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime prodDate))
                    {
                        Console.WriteLine("Неверный формат даты!");
                        break;
                    }
                    Console.Write("Введите срок годности (гггг-мм-дд): ");
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime expiryDate))
                    {
                        Console.WriteLine("Неверный формат даты!");
                        break;
                    }
                    Console.Write("Введите объем производства: ");
                    if (!int.TryParse(Console.ReadLine(), out int prodVolume))
                    {
                        Console.WriteLine("Неверный объем!");
                        break;
                    }
                    Console.Write("Введите цену: ");
                    if (!double.TryParse(Console.ReadLine(), out double price))
                    {
                        Console.WriteLine("Неверная цена!");
                        break;
                    }
                    Product product = new Product(productIdCounter++, productName, weight, prodDate, expiryDate, prodVolume, price);
                    // Добавление ингредиентов
                    string[] ingredientNames = { "Вода", "Мука пшеничная", "Мука ржаная", "Отруби", "Сахар", "Масло подсолнечное", "Соль", "Дрожжи", "Добавки" };
                    foreach (var ingName in ingredientNames)
                    {
                        Console.Write($"Добавить {ingName}? (да/нет): ");
                        if (Console.ReadLine().ToLower() == "да")
                        {
                            Console.Write($"Введите количество {ingName} (кг): ");
                            if (double.TryParse(Console.ReadLine(), out double quantity))
                            {
                                Console.Write($"Введите дату поставки (гггг-мм-дд): ");
                                if (DateTime.TryParse(Console.ReadLine(), out DateTime supplyDate))
                                {
                                    Console.Write($"Введите срок годности (гггг-мм-дд): ");
                                    if (DateTime.TryParse(Console.ReadLine(), out DateTime ingExpiryDate))
                                    {
                                        product.Ingredients.Add(new Ingredient(ingredientIdCounter++, ingName, quantity, supplyDate, ingExpiryDate));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный формат даты!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Неверный формат даты!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Неверное количество!");
                            }
                        }
                    }
                    bakery.Products.Add(product);
                    Console.WriteLine("Изделие добавлено!");
                    break;

                case 3: // Удалить изделие
                    Console.Write("Введите название хлебозавода: ");
                    string bakeryNameForDelete = Console.ReadLine();
                    Bakery bakeryToDelete = bakeries.Find(b => b.Name == bakeryNameForDelete);
                    if (bakeryToDelete == null)
                    {
                        Console.WriteLine("Хлебозавод не найден!");
                        break;
                    }
                    Console.Write("Введите название изделия: ");
                    string productNameToDelete = Console.ReadLine();
                    Product productToDelete = bakeryToDelete.Products.Find(p => p.Name == productNameToDelete);
                    if (productToDelete == null)
                    {
                        Console.WriteLine("Изделие не найдено!");
                        break;
                    }
                    bakeryToDelete.Products.Remove(productToDelete);
                    Console.WriteLine("Изделие удалено!");
                    break;

                case 4: // Показать изделия хлебозавода
                    Console.Write("Введите название хлебозавода: ");
                    string bakeryNameForShow = Console.ReadLine();
                    Bakery bakeryToShow = bakeries.Find(b => b.Name == bakeryNameForShow);
                    if (bakeryToShow == null)
                    {
                        Console.WriteLine("Хлебозавод не найден!");
                        break;
                    }
                    Console.WriteLine($"Изделия хлебозавода {bakeryNameForShow}:");
                    foreach (var p in bakeryToShow.Products)
                    {
                        Console.WriteLine($" - {p.Name}, Вес: {p.Weight} кг, Объем: {p.ProductionVolume}, Цена: {p.Price}, Срок годности: {p.ExpiryDate.ToShortDateString()}");
                    }
                    break;

                case 5: // Суммарная стоимость изделий
                    Console.Write("Введите название хлебозавода: ");
                    string bakeryNameForCost = Console.ReadLine();
                    Bakery bakeryForCost = bakeries.Find(b => b.Name == bakeryNameForCost);
                    if (bakeryForCost == null)
                    {
                        Console.WriteLine("Хлебозавод не найден!");
                        break;
                    }
                    double totalCost = bakeryForCost.Products.Sum(p => p.Price * p.ProductionVolume);
                    Console.WriteLine($"Суммарная стоимость изделий: {totalCost}");
                    break;

                case 6: // Изделия с просроченными ингредиентами
                    bool foundExpired = false;
                    foreach (var b in bakeries)
                    {
                        foreach (var p in b.Products)
                        {
                            foreach (var ing in p.Ingredients)
                            {
                                if (p.ProductionDate > ing.ExpiryDate)
                                {
                                    Console.WriteLine($"Изделие: {p.Name} (Хлебозавод: {b.Name}) произведено после истечения срока годности ингредиента {ing.Name} ({ing.ExpiryDate.ToShortDateString()})");
                                    foundExpired = true;
                                }
                            }
                        }
                    }
                    if (!foundExpired)
                    {
                        Console.WriteLine("Изделий с просроченными ингредиентами не найдено.");
                    }
                    break;

                case 7: // Отсортировать хлебозаводы по объему производства
                    var sortedBakeries = bakeries.OrderByDescending(b => b.Products.Sum(p => p.ProductionVolume)).ToList();
                    Console.WriteLine("Хлебозаводы по убыванию объема производства:");
                    foreach (var b in sortedBakeries)
                    {
                        int totalVolume = b.Products.Sum(p => p.ProductionVolume);
                        Console.WriteLine($" - {b.Name}, Объем производства: {totalVolume}");
                    }
                    break;

                case 8: // Изделие с максимальным количеством ингредиентов
                    Product maxIngredientsProduct = null;
                    int maxIngredientsCount = 0;
                    Bakery maxIngredientsBakery = null;
                    foreach (var b in bakeries)
                    {
                        foreach (var p in b.Products)
                        {
                            if (p.Ingredients.Count > maxIngredientsCount)
                            {
                                maxIngredientsCount = p.Ingredients.Count;
                                maxIngredientsProduct = p;
                                maxIngredientsBakery = b;
                            }
                        }
                    }
                    if (maxIngredientsProduct != null)
                    {
                        Console.WriteLine($"Изделие с максимальным количеством ингредиентов: {maxIngredientsProduct.Name} (Хлебозавод: {maxIngredientsBakery.Name}, Ингредиентов: {maxIngredientsCount})");
                    }
                    else
                    {
                        Console.WriteLine("Изделий не найдено.");
                    }
                    break;

                case 9: // Изделие с максимальной прибылью
                    Product maxProfitProduct = null;
                    double maxProfit = 0;
                    Bakery maxProfitBakery = null;
                    foreach (var b in bakeries)
                    {
                        foreach (var p in b.Products)
                        {
                            double profit = p.Price * p.ProductionVolume;
                            if (profit > maxProfit)
                            {
                                maxProfit = profit;
                                maxProfitProduct = p;
                                maxProfitBakery = b;
                            }
                        }
                    }
                    if (maxProfitProduct != null)
                    {
                        Console.WriteLine($"Изделие с максимальной прибылью: {maxProfitProduct.Name} (Хлебозавод: {maxProfitBakery.Name}, Прибыль: {maxProfit})");
                    }
                    else
                    {
                        Console.WriteLine("Изделий не найдено.");
                    }
                    break;

                case 10: // Показать все данные
                    Console.WriteLine("Хлебозаводы:");
                    foreach (var b in bakeries)
                    {
                        Console.WriteLine($" - {b.Name}, Дата производства: {b.ProductionDate.ToShortDateString()}");
                        Console.WriteLine("  Изделия:");
                        foreach (var p in b.Products)
                        {
                            Console.WriteLine($"    - {p.Name}, Вес: {p.Weight} кг, Объем: {p.ProductionVolume}, Цена: {p.Price}, Срок годности: {p.ExpiryDate.ToShortDateString()}");
                            Console.WriteLine("      Ингредиенты:");
                            foreach (var ing in p.Ingredients)
                            {
                                Console.WriteLine($"        - {ing.Name}, Количество: {ing.Quantity} кг, Дата поставки: {ing.SupplyDate.ToShortDateString()}, Срок годности: {ing.ExpiryDate.ToShortDateString()}");
                            }
                        }
                    }
                    break;

                case 11: // Выход
                    Console.WriteLine("Выход...");
                    return;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.WriteLine("Нажмите Enter...");
            Console.ReadLine();
        }
    }
}

