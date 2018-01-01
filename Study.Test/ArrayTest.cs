using System;
using NUnit.Framework;

namespace Study.Test
{
    [TestFixture]
    public class ArrayTest : TestBase
    {
        private int[][] matrix4by4 =
        {
            new[] { 1, 2, 4, 6 },
            new[] { 2, 4, 7, 8 },
            new[] { 8, 9, 10, 11 },
            new[] { 9, 12, 13, 15 }
        };

        private int[] descAscArray = { 50, 48, 37, 26, 15, 4, -3, 2, 11, 19, 28};

        private int[,] binary2dArray = {
            {1, 1, 0, 0, 0, 1, 1, 0, 0, 0},
            {0, 1, 0, 0, 1, 0, 1, 0, 0, 1},
            {1, 0, 0, 1, 1, 1, 0, 0, 1, 1},
            {0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
            {1, 0, 1, 0, 1, 1, 0, 1, 0, 1},
            {1, 1, 0, 0, 0, 1, 1, 0, 0, 0},
            {0, 1, 0, 0, 1, 0, 1, 0, 0, 1},
            {1, 0, 0, 1, 1, 1, 0, 0, 1, 1},
            {0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
            {1, 0, 1, 0, 1, 1, 0, 1, 0, 1}
        };

        [TestCase(7)]
        public virtual void CheckThatNumberExistsIn2DMatrix(int numberToFind)
        {
            Assert.That(ArrayService.FindInSorted2DMatrix(matrix4by4, numberToFind), Is.True);
        }

        [TestCase(5)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix1(int numberToFind)
        {
            Assert.That(ArrayService.FindInSorted2DMatrix(matrix4by4, numberToFind), Is.False);
        }

        [TestCase(0)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix2(int numberToFind)
        {
            Assert.That(ArrayService.FindInSorted2DMatrix(matrix4by4, numberToFind), Is.False);
        }

        [TestCase(16)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix3(int numberToFind)
        {
            Assert.That(ArrayService.FindInSorted2DMatrix(matrix4by4, numberToFind), Is.False);
        }
        [Test]
        public virtual void CanFindLeastElementInDescAscSortedArray()
        {
            Assert.AreEqual(-3, ArrayService.FindMinElementInDescAscSortedArray(descAscArray, 0, descAscArray.Length - 1));
        }

        [Test]
        public virtual void CanReturnNumberOfIslandsInMatrix()
        {
            ArrayUtility.Print2DArray(binary2dArray);
            Assert.AreEqual(8, ArrayService.NumberOfIslands(binary2dArray));
        }
    }
}
