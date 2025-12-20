using System;

namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("=== Меню ===");
                Console.WriteLine("1. Отгадай ответ");
                Console.WriteLine("2. Информация об авторе");
                Console.WriteLine("3. Сортировка массива");
                Console.WriteLine("4. Игра Крестики-нолики");
                Console.WriteLine("5. Выход");

                int choice = InputValidator.ReadInt("Выберите пункт меню: ", 1, 5);

                switch (choice)
                {
                    case 1:
                        double a = InputValidator.ReadDouble("Введите a: ");
                        double b = InputValidator.ReadDouble("Введите b: ");
                        double result = GuessGame.CalculateFunction(a, b);
                        GuessGame.PlayGuessGame(result, 3);
                        break;
                    case 2:
                        Console.WriteLine("Королева Екатерина, группа: 6106-090301D");
                        break;
                    case 3:
                        int size = InputValidator.ReadInt("Введите размер массива: ", 1, 1000);
                        ArrayWorker arr = new ArrayWorker(size);
                        double timeGnome, timeInsertion;
                        int[] gnome = arr.GnomeSort(out timeGnome);
                        int[] insertion = arr.ShellSort(out timeInsertion);
                                                    
                        Console.WriteLine("Гномья сортировка:");
                        if (gnome.Length <= 10) foreach (var item in gnome) Console.Write(item + " ");
                        Console.WriteLine($"\nВремя: {timeGnome:F4} мс");

                        Console.WriteLine("Сортировка вставками:");
                        if (insertion.Length <= 10) foreach (var item in insertion) Console.Write(item + " ");
                        Console.WriteLine($"\nВремя: {timeInsertion:F4} мс");
                        break;
                    case 4:
                        TicTacToeGame game = new TicTacToeGame();
                        game.Play();
                        break;
                    case 5:
                        exitProgram = ConfirmExit();
                        break;
                }
            }
        }

        static bool ConfirmExit()
        {
            Console.Write("Вы уверены, что хотите выйти (д/н)? ");
            string ans = Console.ReadLine()?.ToLower();
            while (ans != "д" && ans != "н")
            {
                Console.Write("Введите 'д' или 'н': ");
                ans = Console.ReadLine()?.ToLower();
            }
            return ans == "д";
        }
    }
}
