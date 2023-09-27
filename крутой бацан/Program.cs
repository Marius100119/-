class krutoybatsan
{
    static void zhopa()
    {
        Console.WriteLine("Выберите программу:");
        Console.WriteLine("1. Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");

        int vibor = int.Parse(Console.ReadLine());

        switch (vibor)
        {
            case 1:
                Console.WriteLine("Запуск программы <Угадай число>");
                int chislo = new Random().Next(0, 101);
                int ygadai;

                Console.WriteLine("Угадай число от 0 до 100:");

                do
                {
                    ygadai = int.Parse(Console.ReadLine());

                    if (ygadai < chislo)
                    {
                        Console.WriteLine("Больше");
                    }
                    else if (ygadai > chislo)
                    {
                        Console.WriteLine("Меньше");
                    }
                    else
                    {
                        Console.WriteLine("Поздавляем число угадано: {chislo}");
                    }
                } while (ygadai != chislo);
                break;

            case 2:
                Console.WriteLine("Запуск программы <Таблица умножения>");
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i} x {j} = {i * j}\t,");
                    }
                    Console.WriteLine();
                    continue;
                }
                break;

            case 3:
                Console.WriteLine("Запуск программы <Вывод делителей числа>");
                int number = 1000;
                Console.WriteLine($"Делители числа {number}:");

                for (int x = 1; x <= number; x++)
                {
                    if (number % x == 0)
                    {
                        Console.WriteLine(x);
                        continue;
                    }
                }
                break;

            default:
                Console.WriteLine("Некоректный ввод");
                break;
        }
    }
}