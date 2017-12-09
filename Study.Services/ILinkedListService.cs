using Study.Models.LinkedLists;

namespace Study.Services
{
    public interface ILinkedListService
    {
        SinglyLinkedListNode CreateSinglyListNode(int data);
        SinglyLinkedListNode GenerateSinglyLinkedList(int numLinearNodes, int numCyclicNodes);
        bool SinglyLinkedListContainsCycle(SinglyLinkedListNode head);
    }
}