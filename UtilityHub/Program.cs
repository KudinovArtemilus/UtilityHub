using UtilityHub;
Console.WriteLine("1 - Калькулятор");
Console.WriteLine("2 - Конвертер температур");
Console.WriteLine("3 - Статистика чисел");
Console.WriteLine("4 - Генератор паролей");
Console.WriteLine("0 - Выход");

string choice = Console.ReadLine();
while (choice != "exit" && choice != "0")
{
   switch (choice)
    {
        case "1":
            Calculator.Start();
            break;
        case "2":
            TemperatureConverter.Start();
            break;
        case "3":
            NumberStatistics.Start();
            break;
        case "4":
            PasswordGenerator.Start();
            break;
        default:
            Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
            break;
    }
    Console.WriteLine("1 - Калькулятор");
    Console.WriteLine("2 - Конвертер температур");
    Console.WriteLine("3 - Статистика чисел");
    Console.WriteLine("4 - Генератор паролей");
    Console.WriteLine("0 - Выход");
    choice = Console.ReadLine();
}

