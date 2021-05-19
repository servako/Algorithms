namespace TreeTraversal
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        public BinaryTreeNode Left { get; set; }

        public BinaryTreeNode Right { get; set; }

        public int Data { get; set; }
    }
}