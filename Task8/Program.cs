using System;

class Program
{
    static void Main()
    {
        // Ввод числа от 10 до 99
        Console.Write("Введите целое число от 10 до 99: ");
        string input = Console.ReadLine();

        // Попытка преобразовать введенную строку в целое число
        if (int.TryParse(input, out int number))
        {
            // Проверка, что число находится в допустимом диапазоне
            if (number >= 10 && number <= 99)
            {
                // Нахождение и вывод наибольшей цифры числа
                int maxDigit = FindMaxDigit(number);
                Console.WriteLine($"Наибольшая цифра в числе {number}: {maxDigit}");
            }
            else
            {
                Console.WriteLine("Введенное число не находится в диапазоне от 10 до 99.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
        }
    }

    // Функция для нахождения наибольшей цифры в числе
    static int FindMaxDigit(int num)
    {
        int maxDigit = 0;

        while (num > 0)
        {
            int digit = num % 10;
            maxDigit = Math.Max(maxDigit, digit);
            num /= 10;
        }

        return maxDigit;
    }
}
