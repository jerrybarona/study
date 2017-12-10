using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Models.LinkedLists
{
    public class SinglyLinkedNode : Node
    {
        public SinglyLinkedNode Next { get; set; }
        public SinglyLinkedNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
