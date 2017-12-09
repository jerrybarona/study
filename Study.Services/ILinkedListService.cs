using Study.Models.LinkedLists;

namespace Study.Services
{
    public delegate void NodeMethod(SinglyLinkedNode node);
    public interface ILinkedListService
    {
        SinglyLinkedNode CreateSinglyLinkedNode(int data);
        SinglyLinkedNode GenerateSinglyLinkedList(int numLinearNodes, int numCyclicNodes);
        void TraverseSinglyLinkedList(SinglyLinkedNode head, NodeMethod nodeMethod);
        bool SinglyLinkedListContainsCycle(SinglyLinkedNode head);
    }
}