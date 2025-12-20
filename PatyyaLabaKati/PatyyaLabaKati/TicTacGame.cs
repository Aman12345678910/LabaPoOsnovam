using System;

namespace Lab2
{
    /// <summary>
    /// Класс игры "Крестики-нолики 10x10"
    /// </summary>
    public class TicTacToeGame
    {
        public const int FieldSize = 10;
        private char[,] _board;

        private const char EmptyCell = ' ';
        private const char PlayerX = 'X';
        private const char PlayerO = 'O';

        public void Play()
        {
            Console.WriteLine("Добро пожаловать в игру Крестики-нолики 10x10!");
            Console.WriteLine("Первый игрок - X, второй игрок - O");
            Console.WriteLine("Для победы нужно собрать линию из 5 символов подряд");

            bool playAgain;
            do
            {
                PlayGame();
                playAgain = AskForNewGame();
            } while (playAgain);
        }

        private void PlayGame()
        {
            _board = new char[FieldSize, FieldSize];
            for (int i = 0; i < FieldSize; i++)
                for (int j = 0; j < FieldSize; j++)
                    _board[i, j] = EmptyCell;

            char currentPlayer = PlayerX;
            int movesCount = 0;
            bool gameActive = true;

            Console.WriteLine("\n=== НОВАЯ ИГРА ===");

            while (gameActive)
            {
                DisplayBoard();
                bool validMove = false;
                while (!validMove)
                    validMove = ProcessMove(currentPlayer);

                movesCount++;

                if (CheckForWin(currentPlayer))
                {
                    DisplayBoard();
                    Console.WriteLine($"\nИгрок {currentPlayer} победил!");
                    gameActive = false;
                }
                else if (movesCount == FieldSize * FieldSize)
                {
                    DisplayBoard();
                    Console.WriteLine("\nНичья!");
                    gameActive = false;
                }
                else
                {
                    currentPlayer = currentPlayer == PlayerX ? PlayerO : PlayerX;
                }
            }
        }

        private void DisplayBoard()
        {
            Console.WriteLine("\n   A B C D E F G H I J");
            Console.WriteLine("  ---------------------");
            for (int i = 0; i < FieldSize; i++)
            {
                Console.Write($"{i} |");
                for (int j = 0; j < FieldSize; j++)
                    Console.Write($"{_board[i, j]}|");
                Console.WriteLine($" {i}");
                if (i < FieldSize - 1) Console.WriteLine("  ---------------------");
            }
        }

        private bool ProcessMove(char player)
        {
            Console.Write("Введите координаты (например, A1): ");
            string input = Console.ReadLine()?.ToUpper().Trim();
            if (string.IsNullOrEmpty(input) || input.Length < 2 || input.Length > 3)
            {
                Console.WriteLine("Неверный формат ввода");
                return false;
            }

            int col = input[0] - 'A';
            if (col < 0 || col >= FieldSize)
            {
                Console.WriteLine("Неверная буква");
                return false;
            }

            if (!int.TryParse(input.Substring(1), out int row) || row < 0 || row >= FieldSize)
            {
                Console.WriteLine("Неверный номер строки");
                return false;
            }

            if (_board[row, col] != EmptyCell)
            {
                Console.WriteLine("Клетка занята");
                return false;
            }

            _board[row, col] = player;
            return true;
        }

        private bool CheckForWin(char player)
        {
            for (int r = 0; r < FieldSize; r++)
                for (int c = 0; c <= FieldSize - 5; c++)
                    if (CheckLine(player, r, c, 0, 1)) return true;

            for (int r = 0; r <= FieldSize - 5; r++)
                for (int c = 0; c < FieldSize; c++)
                    if (CheckLine(player, r, c, 1, 0)) return true;

            for (int r = 0; r <= FieldSize - 5; r++)
                for (int c = 0; c <= FieldSize - 5; c++)
                    if (CheckLine(player, r, c, 1, 1)) return true;

            for (int r = 0; r <= FieldSize - 5; r++)
                for (int c = 4; c < FieldSize; c++)
                    if (CheckLine(player, r, c, 1, -1)) return true;

            return false;
        }

        private bool CheckLine(char player, int startRow, int startCol, int rowStep, int colStep)
        {
            for (int i = 0; i < 5; i++)
                if (_board[startRow + i * rowStep, startCol + i * colStep] != player)
                    return false;
            return true;
        }

        private bool AskForNewGame()
        {
            Console.Write("\nСыграть еще раз? (y/n): ");
            string ans = Console.ReadLine()?.ToLower().Trim();
            while (ans != "y" && ans != "n")
            {
                Console.Write("Введите 'y' или 'n': ");
                ans = Console.ReadLine()?.ToLower().Trim();
            }
            return ans == "y";
        }
    }
}
