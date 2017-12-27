using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Models.Trees
{
    public class BinaryTreeNode : Node
    {
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
