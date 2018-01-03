using Ninject;
using NUnit.Framework;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    [TestFixture]
    public class StackTest : TestBase
    {
        private readonly object[] _arr = { 5, 4, 3, 2, 1, 0, 10, 20, 30, 40, 50};
        private readonly object[] _braces = { 'x','{','x','{','{','[','[','(','(','x','x','x',')',')',']',']','}','}','x','x','x','x','}','x'};

        private IStackService Service { get; set; }

        [SetUp]
        public virtual void BeforeArrayTests()
        {
            Service = Kernel.Get<IStackService>();
        }

        [Test]
        public virtual void CanInitializeStackFromArray()
        {
            Assert.IsTrue(Service.GenerateStackFromArray(_arr));
        }

        [Test]
        public virtual void CanValidateBraceBalancedArray()
        {
            Assert.IsTrue(Service.CheckForBalancedBraces(_braces));
        }
    }
}
