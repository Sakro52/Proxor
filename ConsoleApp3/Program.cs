using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace MathOperations
    {
        /// <summary>
        /// Перечисление математических операций
        /// </summary>
        enum MathOperation
        {
            Сложение=1,Вычетание,Умножнние, Деление    
        }

        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    // Запрашиваем два вещественных числа
                    Console.WriteLine("Введите первое число:");
                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    // Выводим доступные операции
                    Console.WriteLine("\nВыберите математическую операцию (введите номер):");
                    foreach (int i in Enum.GetValues(typeof(MathOperation)))
                    {
                        Console.WriteLine($"{i}. {((MathOperation)i).ToString()}");
                    }

                    // Запрашиваем выбор операции
                    Console.WriteLine("Введите номер операции (0-3):");
                    int operationIndex = Convert.ToInt32(Console.ReadLine());

                    // Проверяем, является ли введенный индекс допустимым
                    if (!Enum.IsDefined(typeof(MathOperation), operationIndex))
                    {
                        Console.WriteLine("Ошибка: Неверный номер операции!");
                        return;
                    }

                    // Приведение индекса к типу перечисления
                    MathOperation operation = (MathOperation)operationIndex;

                    // Выполняем выбранную операцию
                    double result = 0;
                    switch (operation)
                    {
                        case MathOperation.Сложение:
                            result = number1 + number2;
                            break;
                        case MathOperation.Вычетание:
                            result = number1 - number2;
                            break;
                        case MathOperation.Умножнние:
                            result = number1 * number2;
                            break;
                        case MathOperation.Деление:
                            if (number2 == 0)
                            {
                                Console.WriteLine("Ошибка: Деление на ноль!");
                                return;
                            }
                            result = number1 / number2;
                            break;
                    }

                    // Выводим результат
                    Console.WriteLine($"\nРезультат: {number1} {GetOperationSymbol(operation)} {number2} = {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введены некорректные данные! Пожалуйста, используйте числа.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }

                Console.Read();
            }

            /// <summary>
            /// Возвращает символ операции для вывода
            /// </summary>
            static string GetOperationSymbol(MathOperation operation)
            {
                switch (operation)
                {
                    case MathOperation.Сложение:
                        return "+";
                    case MathOperation.Вычетание:
                        return "-";
                    case MathOperation.Умножнние:
                        return "*";
                    case MathOperation.Деление:
                        return "/";
                    default:
                        return "";
                }
            }
        }
    }
    
