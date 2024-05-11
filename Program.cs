while (true)
{
    Console.WriteLine("Меню выбора: ");
    Console.WriteLine("1. Выполнить операцию '+'");
    Console.WriteLine("7. Выйти из программы");

    Console.Write("Выберите действие (1-5): ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {a + b}");
            break;

        case 5:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Некорректный выбор. Попробуйте ещё раз.");
            break;
    }
    Console.WriteLine();
}
