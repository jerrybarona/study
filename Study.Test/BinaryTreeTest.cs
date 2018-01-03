using Ninject;
using NUnit.Framework;
using Study.Models.Trees;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    [TestFixture]
    public class BinaryTreeTest : TestBase
    {
        private static BinaryTreeNode _root = new BinaryTreeNode(1)
        {
            Left = new BinaryTreeNode(2)
            {
                Left = new BinaryTreeNode(4),
                Right = new BinaryTreeNode(5)
            },
            Right = new BinaryTreeNode(3)
            {
                Left = new BinaryTreeNode(6),
                Right = new BinaryTreeNode(7)
            }
        };

        private IBinaryTreeService Service { get; set; }
        private IBinaryTreeUtility Utility { get; set; }

        [SetUp]
        public virtual void BeforeArrayTests()
        {
            Service = Kernel.Get<IBinaryTreeService>();
            Utility = Kernel.Get<IBinaryTreeUtility>();
        }

        [Test]
        public virtual void CanCalculateTreeHeight()
        {
            Utility.LevelOrderPrint(_root);
            Assert.That(Utility.GetBinaryTreeHeight(_root), Is.EqualTo(3));
        }
        

        [TestCase(1, 28)]
        public virtual void CanReturnTheSumOfTreeNodesBelowAGivenLevel(int level, int expectedSum)
        {
            Assert.AreEqual(Service.SumOfElementsInBinaryTreeBelowAGivenLevel(_root, level), expectedSum);
        }
    }
}
