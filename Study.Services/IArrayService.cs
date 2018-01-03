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

        /// <summary>
        /// Given a boolean 2D matrix, find the number of islands. A group of connected 1s forms an island.
        /// For example, the below matrix contains 5 islands
        /// Input : mat[][] = {{1, 1, 0, 0, 0},
        /// {0, 1, 0, 0, 1},
        /// {1, 0, 0, 1, 1},
        /// {0, 0, 0, 0, 0},
        /// {1, 0, 1, 0, 1} 
        /// Output : 5
        /// </summary>
        /// <param name="matrix">
        /// a binary matrix (0 or 1)</param>
        /// <returns>
        /// Integer number of islands in the matrix
        /// </returns>
        int NumberOfIslands(int[,] matrix);

        /// <summary>
        /// Leetcode 496. Next Greater Element I
        /// You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2.
        /// Find all the next greater numbers for nums1's elements in the corresponding places of nums2.
        /// The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2.
        /// If it does not exist, output -1 for this number.
        /// Example 1:
        /// Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
        /// Output: [-1,3,-1]
        /// Explanation:
        /// For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1.
        /// For number 1 in the first array, the next greater number for it in the second array is 3.
        /// For number 2 in the first array, there is no next greater number for it in the second array, so output -1.
        /// </summary>
        /// <param name="findNums">
        /// Int array whose elements' next greater elements are to be found
        /// </param>
        /// <param name="nums">
        /// Int array where the next greater elements are to be taken from
        /// </param>
        /// <returns>
        /// Next Greater element: Int array with same length as findNums
        /// </returns>
        int[] NextGreaterElement(int[] findNums, int[] nums);
    }
}
