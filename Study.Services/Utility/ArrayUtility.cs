using System;

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
            int xlength = matrix.GetLength(0);
            int ylength = matrix.GetLength(1);

            for (var j = 0; j < ylength; ++j)
            {
                for (var i = 0; i < xlength; ++i)
                {
                    Console.Write(matrix[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
