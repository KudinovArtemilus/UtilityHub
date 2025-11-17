using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityHub
{
    internal class PasswordGenerator
    {
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Генератор паролей ===");
                Console.WriteLine("0 — Выход в меню");
                Console.Write("Введите длину пароля: ");

                string input = Console.ReadLine();

                if (input == "0")
                    break;

                if (!int.TryParse(input, out int length) || length <= 0)
                {
                    Console.WriteLine("Ошибка: введите положительное число!");
                    Console.ReadKey();
                    continue;
                }

                string password = GeneratePassword(length);

                Console.WriteLine($"\nВаш пароль: {password}");

                Console.WriteLine("\nНажмите любую клавишу для продолжения…");
                Console.ReadKey();
            }
        }

        private static string GeneratePassword(int length)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string symbols = "!@#$%^&*()_-+=<>?/{}[]|";

            string all = upper + lower + digits + symbols;

            Random rnd = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(all.Length);
                password[i] = all[index];
            }

            return new string(password);
        }
    }

}
