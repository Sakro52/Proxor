using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
        enum UserRole
        {
            Администратор=1,Модератор,Пользователь,Гость
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                { 
                    Console.WriteLine("Доступные роли:");
                    foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
                    {
                        Console.WriteLine($"{(int)role}. {role}");
                    }
                    Console.WriteLine("\nВведите номер роли (1-4):");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int roleIndex))
                    {
                        Console.WriteLine("Ошибка: Введите число, соответствующее номеру роли!");
                        return;
                    }
                    if (!Enum.IsDefined(typeof(UserRole), roleIndex))
                    {
                        Console.WriteLine("Ошибка: Неверный номер роли!");
                        return;
                    }
                    UserRole selectedRole = (UserRole)roleIndex;
                    Console.WriteLine($"\nВы зарегистрированы как {selectedRole.ToString().ToLower()}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }

                Console.Read();
            }
        }
    }

