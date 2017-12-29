using System;

namespace Study.Services
{
    public class ArrayService : IArrayService
    {
        public bool FindInSorted2DMatrix(int[][] matrix, int number)
        {
            int rownumber = matrix.Length - 1;
            int colnumber = matrix[0].Length - 1;

            int row = 0;
            int col = colnumber;

            while (row <= rownumber && col >= 0)
            {
                if (matrix[row][col] == number)
                {
                    return true;
                }
                else if (matrix[row][col] > number)
                {
                    col--;
                    continue;
                }
                else if (matrix[row][col] < number)
                {
                    row++;
                }
            }

            return false;
        }

        public int FindMinElementInDescAscSortedArray(int[] arr, int low, int high)
        {
            if (low == high) return arr[low];
            if (low == high - 1)
            {
                return arr[low] <= arr[high]
                    ? arr[low]
                    : arr[high];
            }
            int mid = (high + low) / 2;
            if (arr[mid] <= arr[mid - 1] && arr[mid] <= arr[mid + 1]) return arr[mid];
            if (arr[mid] < arr[mid - 1] && arr[mid] > arr[mid + 1])
                return FindMinElementInDescAscSortedArray(arr, mid, high);
            else
                return FindMinElementInDescAscSortedArray(arr, low, mid);
        }

        public int NumberOfIslands(int[,] matrix)
        {
            int xlength = matrix.GetLength(0);
            int ylength = matrix.GetLength(1);

            int iCounter = 0;

            // first row
            if (matrix[0, 0] == 1) ++iCounter;

            for (var i = 1; i < xlength; ++i)
            {
                if (matrix[i, 0] == 1)
                {
                    if (matrix[i - 1, 0] == 0) ++iCounter;
                }
            }

            for (int j = 1; j < ylength; ++j)
            {
                for (int i = 0; i < ylength; ++i)
                {
                    if (i == 0)
                    {
                        if (matrix[i, j] == 1)
                        {
                            if (matrix[i, j - 1] == 0 && matrix[i + 1, j - 1] == 0) ++iCounter;
                        }
                        continue;
                    }

                    if (matrix[i,j] == 1)
                    {
                        if (matrix[i - 1, j - 1] == 0 && matrix[i, j - 1] == 0 && matrix[i - 1, j] == 0) ++iCounter;
                        
                    }
                    if ((matrix[i, j - 1] == 1 && matrix[i - 1, j - 1] == 1) ||
                        (matrix[i, j - 1] == 1 && matrix[i - 1, j] == 1)) --iCounter;
                    
                }
            }
            return iCounter;
        }

    }
}
