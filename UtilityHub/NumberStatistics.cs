using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityHub
{
    internal class NumberStatistics
    {
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Статистика чисел ===");
                Console.WriteLine("Введите несколько целых чисел через пробел.");
                Console.WriteLine("ИЛИ 0 для выхода в меню.");
                Console.Write("\nВаш ввод: ");

                string input = Console.ReadLine();

                if (input.Trim() == "0")
                    break;

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int[] numbers = new int[parts.Length];

                bool error = false;

                // Проверка на корректность чисел
                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out numbers[i]))
                    {
                        Console.WriteLine($"Ошибка: '{parts[i]}' не является числом!");
                        error = true;
                        break;
                    }
                }

                if (error)
                {
                    Console.WriteLine("Нажмите любую клавишу для повтора…");
                    Console.ReadKey();
                    continue;
                }

                // --- Вычисления ---
                int min = numbers[0];
                int max = numbers[0];
                int sum = 0;
                int positive = 0;
                int negative = 0;

                foreach (int n in numbers)
                {
                    if (n < min) min = n;
                    if (n > max) max = n;

                    sum += n;

                    if (n > 0) positive++;
                    if (n < 0) negative++;
                }

                double average = (double)sum / numbers.Length;

                // --- Вывод ---
                Console.WriteLine("\n=== Результаты ===");
                Console.WriteLine($"Минимальное число: {min}");
                Console.WriteLine($"Максимальное число: {max}");
                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Среднее значение: {average}");
                Console.WriteLine($"Количество положительных: {positive}");
                Console.WriteLine($"Количество отрицательных: {negative}");

                Console.WriteLine("\nНажмите любую клавишу для продолжения…");
                Console.ReadKey();

            }
        }
    }
}
