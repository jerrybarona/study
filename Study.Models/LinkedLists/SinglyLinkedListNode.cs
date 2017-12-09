using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Models.LinkedLists
{
    public class SinglyLinkedListNode
    {
        public int Value { get; set; }
        public SinglyLinkedListNode Next { get; set; }
        public SinglyLinkedListNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
