using System;

namespace Study.Models.LinkedLists
{
    public class Stack
    {
        private StackNode _topNode;
        public int StackCapacity { get; private set; }
        private int _stackCount;
        public Stack()
        {
            StackCapacity = 10;
            _topNode = null;
            _stackCount = 0;
        }

        public Stack(int stackCapacity) : this()
        {
            if (stackCapacity > 0) { StackCapacity = stackCapacity;}
            else { throw new ArgumentException("Stack capacity must be a positive integer");}
        }

        public Stack(int stackCapacity, object[] elements) : this(stackCapacity)
        {
            if (elements.Length <= StackCapacity - _stackCount)
            {
                foreach (var element in elements)
                {
                    Push(element);
                }
            }
            else
            {
                throw new ArgumentException("Number of initialization elements exceeds stack capacity");
            }
        }

        public void Push(object item)
        {
            if (_stackCount < StackCapacity)
            {
                var current = _topNode;
                var newNode = new StackNode(item) {Next = current};
                _topNode = newNode;
                _stackCount += 1;
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public object Pop()
        {
            if (_stackCount <= 0) throw new InvalidOperationException();

            var result = _topNode.Value;
            _topNode = _topNode.Next;
            _stackCount -= 1;

            return result;
        }

        public object Peek()
        {
            return _topNode.Value;
        }

        public bool IsEmpty()
        {
            return _stackCount == 0;
        }

        public bool IsFull()
        {
            return _stackCount == StackCapacity;
        }

        public int StackCount()
        {
            return _stackCount;
        }
        public void AdjustCapacity(int capacity)
        {
            if (capacity < _stackCount) throw new InvalidOperationException();

            StackCapacity = capacity;
        }

    }
}
