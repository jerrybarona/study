using System;
using System.Collections.Generic;
using Study.Models.Trees;

namespace Study.Services
{
    public class BinaryTreeService : IBinaryTreeService
    {
        public int SumOfElementsInBinaryTreeBelowAGivenLevel(BinaryTreeNode root, int level)
        {
            //return BinaryTreeLevelSum(root, level);
            int height = BinaryTreeHeight(root);
            int sum = 0;
            for (int i = level; i <= height; sum += BinaryTreeLevelSum(root, i++)) ;

            return sum;
        }

        private static int BinaryTreeLevelSum(BinaryTreeNode root, int level)
        {
            if (root == null || level <= 0) return 0;
            if (level == 1)
            {
                return root.Value;
            }

            int result = BinaryTreeLevelSum(root.Left, level - 1);
            result += BinaryTreeLevelSum(root.Right, level - 1);
            return result;            
        }

        private static int BinaryTreeHeight(BinaryTreeNode root)
        {
            if (root == null) return 0;

            int lheight = BinaryTreeHeight(root.Left);
            int rheight = BinaryTreeHeight(root.Right);

            return lheight > rheight
                ? lheight + 1
                : rheight + 1;
        }

        public bool CheckIfIsBinarySearchTree(ref BinaryTreeNode root)
        {
            return true;
        }

        private void PopulateListWithInOrderedElements(BinaryTreeNode root, ref List<int> inOrderList)
        {
            if (root == null)
            {
                return;
            }
            PopulateListWithInOrderedElements(root.Left, ref inOrderList);
            inOrderList.Add(root.Value);

        }
    }
}
