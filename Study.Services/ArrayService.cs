﻿using System;
using System.Linq;
using System.Collections.Generic;
using Study.Services.Utility;

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
            int ylength = matrix.GetLength(0);
            int xlength = matrix.GetLength(1);

            int[,] islands = new int[ylength, xlength];
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            int iCounter = 0;
            int iRecord = 0;


            // first row
            if (matrix[0, 0] == 1) { islands[0, 0] = ++iCounter; ++iRecord; }

            for (var i = 1; i < xlength; ++i)
            {
                if (matrix[0, i] == 1)
                {
                    if (islands[0, i - 1] != 0) { islands[0, i] = islands[0, i - 1]; }
                    else { islands[0, i] = ++iCounter; ++iRecord; }
                }
            }

            for (int j = 1; j < ylength; ++j)
            {
                for (int i = 0; i < xlength; ++i)
                {
                    if (i == 0)
                    {
                        if (matrix[j, i] == 1)
                        {
                            if (islands[j - 1, i] != 0) { islands[j, i] = islands[j - 1, i]; }
                            else { islands[j, i] = ++iCounter; ++iRecord; }
                        }
                        continue;
                    }

                    if (matrix[j, i] == 1)
                    {
                        if (islands[j - 1, i - 1] == 0 && islands[j - 1, i] == 0 && islands[j, i - 1] == 0) { islands[j, i] = ++iCounter; ++iRecord; }
                        else
                        {
                            islands[j, i]
                                = islands[j, i - 1] != 0
                                ? islands[j, i - 1]
                                : islands[j - 1, i - 1] != 0
                                ? islands[j - 1, i - 1]
                                : islands[j - 1, i];
                        }                        
                    }
                    if (islands[j - 1, i] != islands[j, i - 1] && islands[j - 1, i] != 0 && islands[j, i - 1] != 0)
                    {
                        int value = Math.Min(islands[j - 1, i], islands[j, i - 1]);
                        int key = Math.Max(islands[j - 1, i], islands[j, i - 1]);

                        if (!IsConnected(pairs, key, value)) { pairs.Add(key, value); --iRecord; }                        
                    }
                }
            }
            return iRecord;
        }

        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            return new int[1];
        }

        public int[] SearchRange(int[] nums, int target)
        {
            var x = FindLeftmostInRange(nums, 0, nums.Length - 1, target);
            if (x == -1) return new[] {-1, -1};
            var y = FindRightmostInRange(nums, x, nums.Length - 1, target);
            return new[] {x, y};
        }

        private int FindLeftmostInRange(int[] nums, int lo, int hi, int target)
        {
            while (lo != hi)
            {
                var mid = (lo + hi) / 2;
                if (target == nums[mid])
                {
                    return FindLeftmostInRange(nums, lo, mid, target);
                }
                if (target < nums[mid])
                {
                    return FindLeftmostInRange(nums, lo, mid - 1, target);
                }
                return FindLeftmostInRange(nums, mid + 1, hi, target);
            }
            if (lo == hi)
            {
                if (nums[lo] == target) return lo;
            }
            return -1;
        }

        private int FindRightmostInRange(int[] nums, int lo, int hi, int target)
        {
            while (lo != hi)
            {
                var mid = (lo + hi) / 2;
                if (target == nums[mid])
                {
                    return FindRightmostInRange(nums, mid, hi, target);
                }
                if (target > nums[mid])
                {
                    return FindRightmostInRange(nums, mid + 1, hi, target);
                }
                return FindRightmostInRange(nums, lo, mid - 1, target);
            }
            if (lo == hi)
            {
                if (nums[lo] == target) return hi;
            }
            return -1;
        }

        private bool IsConnected(Dictionary<int, int> p, int k, int v)
        {
            int key = k;
            int value = v;
            while (true)
            {
                if (p.TryGetValue(key, out int result))
                {
                    if (result == value) return true;
                    key = result;
                }
                else
                {
                    return false;
                }
            }
        }

        public void LeftRotation(int n, int k, ref int[] a)
        {
            var temp1 = a.Skip(k).Take(n - k).ToList();
            temp1.AddRange(a.Take(k));
            a = temp1.ToArray();
        }

    }
}
