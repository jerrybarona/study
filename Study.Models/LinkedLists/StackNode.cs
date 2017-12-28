namespace Study.Models.LinkedLists
{
    public class StackNode
    {
        public object Value { get; set; }
        public StackNode Next { get; set; }

        public StackNode()
        {
            Value = null;
            Next = null;
        }
        public StackNode(object value) : this()
        {
            Value = value;
        }
    }
}
