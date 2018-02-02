using Study.Models.Trees;

namespace Study.Services
{
    public interface IBinaryTreeService
    {
        /// <summary>
        /// Returns the sum of all elements in a bInary tree below a given level
        /// </summary>
        /// <param name="root"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        int SumOfElementsInBinaryTreeBelowAGivenLevel(BinaryTreeNode root, int level);

        /// <summary>
        /// Hackerrank: Trees: Is This a Binary Search Tree?
        /// For the purposes of this challenge, we define a binary search tree to be a binary tree with the following ordering properties:
        /// - The value of every node in a node's left subtree is less than the data value of that node.
        /// - The value of every node in a node's right subtree is greater than the data value of that node.
        /// Given the root node of a binary tree, can you determine if it's also a binary search tree?
        /// Complete the function in your editor below, which has 1 parameter: a pointer to the root of a binary tree.
        /// It must return a boolean denoting whether or not the binary tree is a binary search tree.
        /// You may have to write one or more helper functions to complete this challenge.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool CheckIfIsBinarySearchTree(ref BinaryTreeNode root);
    }
}
