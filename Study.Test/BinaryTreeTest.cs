using NUnit.Framework;
using Study.Models.Trees;

namespace Study.Test
{
    [TestFixture]
    public class BinaryTreeTest : TestBase
    {
        private static BinaryTreeNode root = new BinaryTreeNode(1)
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

        [Test]
        public virtual void CanCalculateTreeHeight()
        {
            BinaryTreeUtility.LevelOrderPrint(root);
            Assert.That(BinaryTreeUtility.GetBinaryTreeHeight(root), Is.EqualTo(3));
        }
        
    }
}
