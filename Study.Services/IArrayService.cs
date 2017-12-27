using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Services
{
    public interface IArrayService
    {
        bool FindInSorted2DMatrix(int[][] matrix, int number);

        /// <summary>
        /// Given an array of integers that consists of two parts,
        /// one part descending and one part ascending,
        /// sort the array from least to greatest
        /// </summary>
        /// <param name="arr">
        /// Integer array sorted in descending order up to a point
        /// and then sorted in ascending order
        /// </param>
        /// <returns>
        /// Lowest element in the array
        /// </returns>
        int FindMinElementInDescAscSortedArray(int[] arr, int low, int high);
    }
}
