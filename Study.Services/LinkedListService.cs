using System;
using Study.Models.LinkedLists;

namespace Study.Services
{
    public class LinkedListService : ILinkedListService
    {
        public SinglyLinkedNode CreateSinglyLinkedNode(int data = 0)
        {
            return new SinglyLinkedNode(data);
        }

        public SinglyLinkedNode GenerateSinglyLinkedList(int numLinearNodes, int numCyclicNodes)
        {
            if (numLinearNodes < 0 || numCyclicNodes < 0)
            {
                throw new ArgumentException("One of the method arguments is invalid.");
            }
            var rnd = new Random();
            SinglyLinkedNode head = null;
            SinglyLinkedNode linearCurrent = null;
            while (numLinearNodes-- > 0)
            {
                if (head == null)
                {
                    head = CreateSinglyLinkedNode(rnd.Next(0, 100));
                    linearCurrent = head;
                }
                else
                {
                    linearCurrent.Next = CreateSinglyLinkedNode(rnd.Next(0, 100));
                    linearCurrent = linearCurrent.Next;
                }
            }

            if (numCyclicNodes == 0)
            {
                return head;
            }

            SinglyLinkedNode cyclicCurrent = null;
            while (numCyclicNodes-- > 0)
            {
                if (cyclicCurrent == null)
                {
                    if (linearCurrent == null)
                    {
                        head = CreateSinglyLinkedNode(rnd.Next(0, 100));
                        cyclicCurrent = head;
                    }
                    else
                    {
                        linearCurrent.Next = CreateSinglyLinkedNode(rnd.Next(0, 100));
                        cyclicCurrent = linearCurrent.Next;
                    }
                }
                else
                {
                    cyclicCurrent.Next = CreateSinglyLinkedNode(rnd.Next(0, 100));
                    cyclicCurrent = cyclicCurrent.Next;
                }
            }

            if (cyclicCurrent != null)
            {
                cyclicCurrent.Next = linearCurrent;
            }

            return head;
        }

        public bool SinglyLinkedListContainsCycle(SinglyLinkedNode head)
        {
            if (head == null)
            {
                throw new ArgumentNullException();
            }

            var slow = head;
            var fast = head.Next;
            
            while (slow != null && fast != null && slow != fast && slow != fast.Next)
            {
                if (fast.Next != null && fast.Next.Next != null)
                {
                    fast = fast.Next.Next;
                    slow = slow.Next;
                    continue;
                }
                return false;
            }

            if (slow == fast || slow == fast.Next)
            {
                return true;
            }

            return false;
        }

        public void TraverseSinglyLinkedList(SinglyLinkedNode head, NodeMethod nodeMethod)
        {
            var current = head;
            while (current != null)
            {
                nodeMethod(current);
                current = current.Next;
            }
        }
    }
}