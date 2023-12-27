using System;

class Program
{
    static void Main()
    {
        // Ввод натурального числа
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine();

        // Попытка преобразовать введенную строку в целое число
        if (uint.TryParse(input, out uint n))
        {
            // Вывод цифр числа через запятую
            Console.Write("Цифры числа через запятую: ");
            DisplayDigitsSeparatedByComma(n);
        }
        else
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите натуральное число.");
        }
    }

    // Функция для вывода цифр числа через запятую
    static void DisplayDigitsSeparatedByComma(uint number)
    {
        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            Console.Write(numberString[i]);

            // Вывод запятой, если не последняя цифра
            if (i < numberString.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}