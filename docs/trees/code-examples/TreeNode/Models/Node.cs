namespace TreeNode.Models
{
    public class Node
    {
        public class NodeItem
        {
            public int Value { get; set; }
            public NodeItem? Left { get; set; }
            public NodeItem? Right { get; set; }

            public NodeItem(int value = 0, NodeItem? left = null, NodeItem? right = null)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

        public NodeItem? Root { get; set; }

        public Node()
        {
            Root = null;
        }
    }
}
