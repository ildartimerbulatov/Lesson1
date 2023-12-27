using System;

class Program
{
    static void Main()
    {
        // Запрос координат у пользователя
        Console.Write("Введите координату X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Определение номера координатной четверти
        int quadrant = DetermineQuadrant(x, y);

        // Вывод результата
        Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quadrant}-й координатной четверти.");
    }

    // Функция для определения номера координатной четверти
    static int DetermineQuadrant(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }
}