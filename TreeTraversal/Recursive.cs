namespace TreeTraversal{

    public class RecursiveSearch
    {
        public BinaryTreeNode FindCommonAncessor(BinaryTreeNode root, int a, int b)
        {
            if (root == null) return null;
            if (root.Data < a && root.Data < b)
            {
                return FindCommonAncessor(root.Right, a, b);
            }
            else if(root.Data > a && root.Data > b)
            {
                return FindCommonAncessor(root.Left, a, b);
            }
            return root;
        }
    }
}