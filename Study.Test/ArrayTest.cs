using Ninject;
using NUnit.Framework;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    [TestFixture]
    public class ArrayTest : TestBase
    {
        private readonly int[][] _matrix4By4 =
        {
            new[] { 1, 2, 4, 6 },
            new[] { 2, 4, 7, 8 },
            new[] { 8, 9, 10, 11 },
            new[] { 9, 12, 13, 15 }
        };

        private readonly int[] _descAscArray = { 50, 48, 37, 26, 15, 4, -3, 2, 11, 19, 28};

        private readonly int[,] _binary2DArray = {
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

        private IArrayService Service { get; set; }
        private IArrayUtility Utility { get; set; }

        [SetUp]
        public virtual void BeforeArrayTests()
        {
            Service = Kernel.Get<IArrayService>();
            Utility = Kernel.Get<IArrayUtility>();
        }

        [TestCase(7)]
        public virtual void CheckThatNumberExistsIn2DMatrix(int numberToFind)
        {
            Assert.That(Service.FindInSorted2DMatrix(_matrix4By4, numberToFind), Is.True);
        }

        [TestCase(5)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix1(int numberToFind)
        {
            Assert.That(Service.FindInSorted2DMatrix(_matrix4By4, numberToFind), Is.False);
        }

        [TestCase(0)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix2(int numberToFind)
        {
            Assert.That(Service.FindInSorted2DMatrix(_matrix4By4, numberToFind), Is.False);
        }

        [TestCase(16)]
        public virtual void CheckThatNumberDoesNotExistIn2DMatrix3(int numberToFind)
        {
            Assert.That(Service.FindInSorted2DMatrix(_matrix4By4, numberToFind), Is.False);
        }
        [Test]
        public virtual void CanFindLeastElementInDescAscSortedArray()
        {
            Assert.AreEqual(-3, Service.FindMinElementInDescAscSortedArray(_descAscArray, 0, _descAscArray.Length - 1));
        }

        [Test]
        public virtual void CanReturnNumberOfIslandsInMatrix()
        {
            Utility.Print2DArray(_binary2DArray);
            Assert.AreEqual(8, Service.NumberOfIslands(_binary2DArray));
        }
    }
}
