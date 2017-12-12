using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Study.Services;
using Study.Models.LinkedLists;

namespace Study.Test
{
    [TestFixture]
    public class LinkedListTest : TestBase
    {
        [Test]
        public virtual void CheckListContainsCycle()
        {
            SinglyLinkedNode list = LinkedListService.GenerateSinglyLinkedList(3, 3);
            Assert.That(LinkedListService.SinglyLinkedListContainsCycle(list), Is.True);
        }
    }
}
