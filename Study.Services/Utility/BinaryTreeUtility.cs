using System;
using Study.Models.Trees;

namespace Study.Services.Utility
{
    public class BinaryTreeUtility : IBinaryTreeUtility
    {
        public int GetBinaryTreeHeight(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = GetBinaryTreeHeight(root.Left);
            int rightHeight = GetBinaryTreeHeight(root.Right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        public void InOrderPrint(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrderPrint(root.Left);
            Console.Write(root.Value.ToString() + " ");
            InOrderPrint(root.Right);
        }

        public void LevelOrderPrint(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            int height = GetBinaryTreeHeight(root);
            for (int i = 1; i <= height; PrintLevel(root, i++)) ;
        }

        public void PostOrderPrint(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderPrint(root.Left);
            PostOrderPrint(root.Right);
            Console.Write(root.Value.ToString() + " ");
        }

        public void PreOrderPrint(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.Value.ToString() + " ");
            PreOrderPrint(root.Left);
            PreOrderPrint(root.Right);
        }

        public void PrintLevel(BinaryTreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }

            if (level == 1)
            {
                Console.Write(root.Value.ToString() + " ");
            }

            else if (level > 1)
            {
                PrintLevel(root.Left, level - 1);
                PrintLevel(root.Right, level - 1);
            }
        }
    }
}
