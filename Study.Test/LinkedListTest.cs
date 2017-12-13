using NUnit.Framework;
using Study.Models.LinkedLists;

namespace Study.Test
{
    [TestFixture]
    public class LinkedListTest : TestBase
    {
        [TestCase(3, 3)]
        public virtual void CheckListContainsCycle(int a, int b)
        {
            SinglyLinkedNode list = LinkedListService.GenerateSinglyLinkedList(a, b);
            Assert.That(LinkedListService.SinglyLinkedListContainsCycle(list), Is.True);
        }
        [Test]
        public virtual void CheckListDoesNotContainsCycle()
        {
            SinglyLinkedNode list = LinkedListService.GenerateSinglyLinkedList(3, 0);
            Assert.That(LinkedListService.SinglyLinkedListContainsCycle(list), Is.False);
        }
    }
}
