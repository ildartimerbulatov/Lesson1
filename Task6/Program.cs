using System;

class Program
{
    static void Main()
    {
        // Запрос числа у пользователя
        Console.Write("Введите число: ");

        // Считывание введенного числа
        string input = Console.ReadLine();

        // Попытка преобразовать введенную строку в целое число
        if (int.TryParse(input, out int number))
        {
            // Проверка, кратно ли введенное число одновременно 7 и 23
            if (IsMultipleOf7And23(number))
            {
                Console.WriteLine($"{number} кратно 7 и 23 одновременно.");
            }
            else
            {
                Console.WriteLine($"{number} не кратно 7 и 23 одновременно.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Введите целое число.");
        }
    }

    // Функция для проверки, кратно ли число одновременно 7 и 23
    static bool IsMultipleOf7And23(int number)
    {
        return (number % 7 == 0) && (number % 23 == 0);
    }
}