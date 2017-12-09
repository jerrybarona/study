using System;
using Study.Models.LinkedLists;

namespace Study.Services
{
    public class LinkedListService : ILinkedListService
    {
        public SinglyLinkedListNode CreateSinglyListNode(int data = 0)
        {
            return new SinglyLinkedListNode(data);
        }

        public SinglyLinkedListNode GenerateSinglyLinkedList(int numLinearNodes, int numCyclicNodes)
        {
            if (numLinearNodes < 0 || numCyclicNodes < 0)
            {
                throw new ArgumentException("One of the method arguments is invalid.");
            }
            var rnd = new Random();
            SinglyLinkedListNode head = null;
            SinglyLinkedListNode linearCurrent = null;
            while (numLinearNodes-- > 0)
            {
                if (head == null)
                {
                    head = CreateSinglyListNode(rnd.Next());
                    linearCurrent = head;
                }
                else
                {
                    linearCurrent.Next = CreateSinglyListNode(rnd.Next());
                    linearCurrent = linearCurrent.Next;
                }
            }

            if (numCyclicNodes == 0)
            {
                return head;
            }

            SinglyLinkedListNode cyclicCurrent = null;
            while (numCyclicNodes-- > 0)
            {
                if (cyclicCurrent == null)
                {
                    if (linearCurrent == null)
                    {
                        head = CreateSinglyListNode(rnd.Next());
                        cyclicCurrent = head;
                    }
                    else
                    {
                        linearCurrent.Next = CreateSinglyListNode(rnd.Next());
                        cyclicCurrent = linearCurrent.Next;
                    }
                }
                else
                {
                    cyclicCurrent.Next = CreateSinglyListNode(rnd.Next());
                    cyclicCurrent = cyclicCurrent.Next;
                }
            }

            if (cyclicCurrent != null)
            {
                cyclicCurrent.Next = linearCurrent;
            }

            return head;
        }

        public bool SinglyLinkedListContainsCycle(SinglyLinkedListNode head)
        {
            if (head == null)
            {
                throw new ArgumentNullException();
            }
            SinglyLinkedListNode slow = head;
            SinglyLinkedListNode fast = head.Next;

            while (slow != null || fast != null || slow != fast || slow != fast.Next)
            {
                if (fast.Next != null && fast.Next.Next != null)
                {
                    fast = fast.Next.Next;
                    head = head.Next;
                    continue;
                }
                return true;
            }

            return false;
        }
    }
}