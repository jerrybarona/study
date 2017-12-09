using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.Models.LinkedLists;

namespace Study.Services.Utility
{
    public class LinkedListUtility : ILinkedListUtility
    {
        public void PrintNode(SinglyLinkedNode node)
        {
            Console.WriteLine("At node -> " + node.Value.ToString());
        }
    }
}
