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
    }
}
