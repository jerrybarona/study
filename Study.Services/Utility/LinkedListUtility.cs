using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study.Models;

namespace Study.Services.Utility
{
    public class LinkedListUtility : ILinkedListUtility
    {
        public void PrintNode(Node node)
        {
            Console.WriteLine("At node -> " + node.Value.ToString());
        }

        public void PrintNodeValue(Node node)
        {
            Console.Write(node.Value.ToString() + " ");
        }
    }
}
