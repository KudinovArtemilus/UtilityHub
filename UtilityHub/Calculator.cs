using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityHub
{
    internal class Calculator
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("----Калькулятор запущен----");
            string ch = "1";
            while (ch == "1")
            {
                Console.Write("Введите 1 число: ");
                
                double inputNumberFirst = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите 2 число: ");
                double inputNumberF = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите операцию (+, -, *, /): ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Результат: {inputNumberFirst + inputNumberF}");
                        break;
                    case "-":
                        Console.WriteLine($"Результат: {inputNumberFirst - inputNumberF}");
                        break;
                    case "*":
                        Console.WriteLine($"Результат: {inputNumberFirst * inputNumberF}");
                        break;
                    case "/":
                        if (inputNumberF != 0)
                            Console.WriteLine($"Результат: {inputNumberFirst / inputNumberF}");
                        else
                            Console.WriteLine("Ошибка: деление на ноль!");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция.");
                        break;
                }
                Console.Write("Продолжить? (1 - да, 0 - нет): ");
                ch = Console.ReadLine();
            }

        }
    }
}
