while (true)
{
    Console.WriteLine("Меню выбора: ");
    Console.WriteLine("1. Выполнить операцию '+'");
    Console.WriteLine("2. Выполнить операцию '-'");
    Console.WriteLine("3. Выполнить операцию '*'");
    Console.WriteLine("5. Выйти из программы");

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

        case 2:
            Console.WriteLine("Введите число А: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {c - d}");
            break;

        case 3:
            Console.WriteLine("Введите число А: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {f * e}");
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
