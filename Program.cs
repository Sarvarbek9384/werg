using System;

class Program
{
    static void Main()
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выйти");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GuessNumberGame();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    FindDivisors();
                    break;
                case 4:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор программы.");
                    break;
            }
        }
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int targetNumber = random.Next(101);

        Console.WriteLine("Игра 'Угадай число'");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуй угадать!");

        int guess = -1;
        int attempts = 0;
        while (guess != targetNumber)
        {
            Console.Write("Введи число: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("Мое число больше.");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Мое число меньше.");
            }
        }

        Console.WriteLine($"Ура! Ты угадал число за {attempts} попыток.");
        Console.WriteLine();
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("Таблица умножения");

        int[,] table = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                table[row, col] = (row + 1) * (col + 1);
            }
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write($"{table[row, col],4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void FindDivisors()
    {
        Console.WriteLine("Вывод делителей числа");
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Делители числа: ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
