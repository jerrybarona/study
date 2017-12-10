using Study.Models;
using Study.Models.LinkedLists;

namespace Study.Services
{
    public delegate void NodeMethod(Node node);
    public interface ILinkedListService
    {
        SinglyLinkedNode CreateSinglyLinkedNode(int data);
        SinglyLinkedNode GenerateSinglyLinkedList(int numLinearNodes, int numCyclicNodes);
        void TraverseSinglyLinkedList(SinglyLinkedNode head, NodeMethod nodeMethod);
        bool SinglyLinkedListContainsCycle(SinglyLinkedNode head);

        RightAndDownPointingNode CreateRightAndDownPointingNode(int data);
        RightAndDownPointingNode GenerateLinkedListFrom2DMatrix(int[][] matrix, int m, int n, int i, int j);
        void TraverseMatrixLinkList(RightAndDownPointingNode head, NodeMethod nodeMethod);
    }
}