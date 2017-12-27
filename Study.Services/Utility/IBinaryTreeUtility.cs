using Study.Models.Trees;

namespace Study.Services.Utility
{
    public interface IBinaryTreeUtility
    {
        void PreOrderPrint(BinaryTreeNode root);
        void InOrderPrint(BinaryTreeNode root);
        void PostOrderPrint(BinaryTreeNode root);
        void LevelOrderPrint(BinaryTreeNode root);
        int GetBinaryTreeHeight(BinaryTreeNode root);
        void PrintLevel(BinaryTreeNode root, int level);
    }
}
