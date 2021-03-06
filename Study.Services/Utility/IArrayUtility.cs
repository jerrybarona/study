﻿namespace Study.Services.Utility
{
    public interface IArrayUtility
    {
        void PrintArray(int[] arr);
        void PrintMatrix(int[][] matrix);
        void Print2DArray(int[,] matrix);
        void QuickSort(int[] arr, int low, int high);
        void PrintArrayLinq(ref int[] arr);
    }
}
