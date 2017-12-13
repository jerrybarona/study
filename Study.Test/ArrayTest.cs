using NUnit.Framework;

namespace Study.Test
{
    [TestFixture]
    public class ArrayTest : TestBase
    {
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
    }
}
