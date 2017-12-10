namespace Study.Models.LinkedLists
{
    public class RightAndDownPointingNode : Node
    {
        public RightAndDownPointingNode Right { get; set; }
        public RightAndDownPointingNode Down { get; set; }
        public RightAndDownPointingNode(int data)
        {
            Value = data;
            Right = null;
            Down = null;
        }
    }
}
