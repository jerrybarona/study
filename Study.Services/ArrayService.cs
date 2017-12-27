using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
