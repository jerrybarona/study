using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
