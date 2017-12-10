using System;
using Study.Models.LinkedLists;

namespace Study.Services
{
    public class LinkedListService : ILinkedListService
    {
        public RightAndDownPointingNode CreateRightAndDownPointingNode(int data = 0)
        {
            return new RightAndDownPointingNode(data);
        }

        public SinglyLinkedNode CreateSinglyLinkedNode(int data = 0)
        {
            return new SinglyLinkedNode(data);
        }

        public RightAndDownPointingNode GenerateLinkedListFrom2DMatrix(int[][] matrix, int m, int n, int i, int j)
        {
            if (i > n - 1 || j > m - 1)
            {
                return null;
            }

            RightAndDownPointingNode temp = CreateRightAndDownPointingNode(matrix[i][j]);
            temp.Right = GenerateLinkedListFrom2DMatrix(matrix, m, n, i + 1, j);
            temp.Down = GenerateLinkedListFrom2DMatrix(matrix, m, n, i, j + 1);
            return temp;
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

        public void TraverseMatrixLinkList(RightAndDownPointingNode head, NodeMethod nodeMethod)
        {
            RightAndDownPointingNode rightward = head;
            RightAndDownPointingNode downward = head;

            while (downward != null)
            {
                rightward = downward;
                while (rightward != null)
                {
                    nodeMethod(rightward);
                    rightward = rightward.Right;
                }
                Console.WriteLine();
                downward = downward.Down;
            }
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