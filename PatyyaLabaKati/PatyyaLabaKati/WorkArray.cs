using System;
using System.Diagnostics;

namespace Lab2
{
    /// <summary>
    /// Класс для работы с массивами
    /// </summary>
    public class ArrayWorker
    {
        private int[] _array;
        private int _length;

        public int Length
        {
            get { return _length; }
        }
        public int[] Array
        {
            get { return _array; }
        }

        /// <summary>
        /// Конструктор по умолчанию: длина массива 10
        /// </summary>
        public ArrayWorker() : this(10) { }

        /// <summary>
        /// Конструктор с параметром длины массива
        /// </summary>
        public ArrayWorker(int length)
        {
            _length = length;
            _array = new int[_length];
            Fill();
        }

        private void Fill()
        {
            Random rnd = new Random();
            for (int i = 0; i < _length; i++)
                _array[i] = rnd.Next(1, 101);
        }

        /// <summary>
        /// Создание копии массива через цикл for
        /// </summary>
        private int[] CopyArray()
        {
            int[] copy = new int[_length];
            for (int i = 0; i < _length; i++)
                copy[i] = _array[i];
            return copy;
        }

        /// <summary>
        /// Гномья сортировка
        /// </summary>
        public int[] GnomeSort(out double elapsedMs)
        {
            int[] arr = CopyArray();
            Stopwatch sw = Stopwatch.StartNew();

            int index = 0;
            while (index < arr.Length)
            {
                if (index == 0 || arr[index] >= arr[index - 1])
                    index++;
                else
                {
                    int temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }

            sw.Stop();
            elapsedMs = sw.Elapsed.TotalMilliseconds;
            return arr;
        }

        /// <summary>
        /// Сортировка Шелла
        /// </summary>
        public int[] ShellSort(out double elapsedMs)
        {
            int[] arr = CopyArray();
            Stopwatch sw = Stopwatch.StartNew();

            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }

            sw.Stop();
            elapsedMs = sw.Elapsed.TotalMilliseconds;
            return arr;
        }

        /// <summary>
        /// Метод для вывода массива на консоль (только если длина ≤ 10)
        /// </summary>
        public void PrintArray(int[] arr)
        {
            if (arr.Length <= 10)
            {
                foreach (var item in arr)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Массив больше 10 элементов, вывод опущен");
            }
        }
    }
}
