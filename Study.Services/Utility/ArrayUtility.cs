using System;
using System.Linq;

namespace Study.Services.Utility
{
    public class ArrayUtility : IArrayUtility
    {
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        public void PrintMatrix(int[][] matrix)
        {
            int i = 0;
            for (int j = 0; j < matrix[i].Length; ++j)
            {
                while (i < matrix.Length)
                {
                    Console.Write(matrix[i++][j].ToString() + " ");
                }
                Console.WriteLine();
                i = 0;
            }
        }

        public void Print2DArray(int[,] matrix)
        {
            int ylength = matrix.GetLength(0);
            int xlength = matrix.GetLength(1);

            for (var j = 0; j < ylength; ++j)
            {
                for (var i = 0; i < xlength; ++i)
                {
                    Console.Write(matrix[j,i] + " ");
                }
                Console.WriteLine();
            }
        }

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                var p = Partition(arr, low, high);
                QuickSort(arr, low, p -1);
                QuickSort(arr, p + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            var pivot = arr[high];
            var i = low - 1;
            for (var j = 0; j <= high; ++j)
            {
                if (arr[j] <= pivot)
                {
                    ++i;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        private static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public void PrintArrayLinq(ref int[] arr)
        {
            arr.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
