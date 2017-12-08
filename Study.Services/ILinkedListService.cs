using Study.Models.LinkedLists;

namespace Study.Services
{
    public interface ILinkedListService
    {
        bool SinglyLinkedListContainsCycle(SinglyLinkedListNode head);
    }
}