using System;

namespace Lab2
{
    /// <summary>
    /// Статический класс для игры "Отгадай ответ"
    /// </summary>
    public static class GuessGame
    {
        /// <summary>
        /// Вычисляет значение функции
        /// </summary>
        public static double CalculateFunction(double a, double b)
        {
            return Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * Math.PI)) + GetRoot(Math.Cos(a + b), 3.0);
        }

        private static double GetRoot(double number, double power)
        {
            return number < 0 ? -Math.Pow(-number, 1.0 / power) : Math.Pow(number, 1.0 / power);
        }

        /// <summary>
        /// Игра угадывания результата
        /// </summary>
        public static void PlayGuessGame(double result, int maxAttempts = 3)
        {
            int usedAttempts = 0;

            while (usedAttempts < maxAttempts)
            {
                Console.Write("Ответ: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double answer))
                {
                    Console.WriteLine("Некорректный ввод. Попытка не засчитана.");
                    continue; // ❌ не засчитываем попытку
                }

                usedAttempts++; // ✅ засчитываем попытку только при корректном вводе

                if (Math.Abs(answer - result) < 0.01)
                {
                    Console.WriteLine("Верно!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Неверно. Осталось попыток: {maxAttempts - usedAttempts}");
                }
            }

            Console.WriteLine($"Правильный ответ: {Math.Round(result, 2)}");
        }
    }
}
