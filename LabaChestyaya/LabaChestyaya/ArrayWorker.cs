using System;
using System.Diagnostics;

namespace LabaChestyaya
{
    public class ArrayWorker
    {
        private int _length;
        private int[] _array;

        public int Length => _length;
        public int[] Array => _array;

        public ArrayWorker()
        {
            _length = 10;
            _array = new int[_length];
            Fill();
        }

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

        public int[] CopyArray()
        {
            int[] copy = new int[_length];
            for (int i = 0; i < _length; i++)
                copy[i] = _array[i];
            return copy;
        }

        public int[] InsertionSort(out double elapsedMs)
        {
            int[] arr = CopyArray();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            sw.Stop();
            elapsedMs = sw.Elapsed.TotalMilliseconds;
            return arr;
        }

        public int[] GnomeSort(out double elapsedMs)
        {
            int[] arr = CopyArray();
            Stopwatch sw = Stopwatch.StartNew();

            int index = 0;
            while (index < arr.Length)
            {
                if (index == 0 || arr[index] >= arr[index - 1])
                {
                    index++;
                }
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
    }
}