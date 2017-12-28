using NUnit.Framework;

namespace Study.Test
{
    [TestFixture]
    public class StackTest : TestBase
    {
        private readonly object[] _arr = { 5, 4, 3, 2, 1, 0, 10, 20, 30, 40, 50};
        private readonly object[] _braces = { 'x','{','x','{','{','[','[','(','(','x','x','x',')',')',']',']','}','}','x','x','x','x','}','x'};

        [Test]
        public virtual void CanInitializeStackFromArray()
        {
            Assert.IsTrue(StackService.GenerateStackFromArray(_arr));
        }

        [Test]
        public virtual void CanValidateBraceBalancedArray()
        {
            Assert.IsTrue(StackService.CheckForBalancedBraces(_braces));
        }
    }
}
