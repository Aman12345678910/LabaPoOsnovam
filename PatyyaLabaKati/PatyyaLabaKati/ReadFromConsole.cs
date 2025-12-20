using System;

namespace Lab2
{
    /// <summary>
    /// Статический класс для проверки ввода пользователя
    /// </summary>
    public static class InputValidator
    {
        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt)) Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number >= min && number <= max)
                    return number;
                Console.WriteLine($"Ошибка! Введите целое число от {min} до {max}.");
            }
        }

        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt)) Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                    return number;
                Console.WriteLine("Ошибка! Введите число.");
            }
        }
    }
}
