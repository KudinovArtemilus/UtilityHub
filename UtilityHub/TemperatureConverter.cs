using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityHub
{
    internal class TemperatureConverter
    {
        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Конвертер температур ===");
                Console.WriteLine("1 — Цельсий → Фаренгейт");
                Console.WriteLine("2 — Фаренгейт → Цельсий");
                Console.WriteLine("0 — Выход в меню");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;

                Console.Write("Введите температуру: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double value))
                {
                    Console.WriteLine("Ошибка: нужно ввести число!");
                    Console.ReadKey();
                    continue;
                }

                double result;

                switch (choice)
                {
                    case "1":
                        result = CelsiusToFahrenheit(value);
                        Console.WriteLine($"{value} °C = {result} °F");
                        break;

                    case "2":
                        result = FahrenheitToCelsius(value);
                        Console.WriteLine($"{value} °F = {result} °C");
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда!");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения…");
                Console.ReadKey();
            }
        }

        // Формула C → F
        private static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        // Формула F → C
        private static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }

}