using Ninject;
using NUnit.Framework;
using Study.Models.LinkedLists;
using Study.Services;
using Study.Services.Utility;

namespace Study.Test
{
    [TestFixture]
    public class LinkedListTest : TestBase
    {

        private ILinkedListService Service { get; set; }
        private ILinkedListUtility Utility { get; set; }

        [SetUp]
        public virtual void BeforeArrayTests()
        {
            Service = Kernel.Get<ILinkedListService>();
            Utility = Kernel.Get<ILinkedListUtility>();
        }

        [TestCase(3, 3)]
        public virtual void CheckListContainsCycle(int a, int b)
        {
            SinglyLinkedNode list = Service.GenerateSinglyLinkedList(a, b);
            Assert.That(Service.SinglyLinkedListContainsCycle(list), Is.True);
        }
        [Test]
        public virtual void CheckListDoesNotContainsCycle()
        {
            SinglyLinkedNode list = Service.GenerateSinglyLinkedList(3, 0);
            Assert.That(Service.SinglyLinkedListContainsCycle(list), Is.False);
        }
    }
}
