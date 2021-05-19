using System.Collections.Generic;

namespace TreeTraversal
{
    public class BreadthFirstSearch
    {
        private Queue<BinaryTreeNode> _searchQueue;

        public BreadthFirstSearch()
        {
            _searchQueue = new Queue<BinaryTreeNode>();
        }

        public BinaryTreeNode Search(BinaryTreeNode rootNode, int a, int b)
        {
            BinaryTreeNode current;
            _searchQueue.Enqueue(rootNode);

            while (_searchQueue.Count != 0)
            {
                current = _searchQueue.Dequeue();
                if (current.Data < a && current.Data < b)
                {
                    _searchQueue.Enqueue(current.Right);
                }
                else if (current.Data > a && current.Data > b)
                {
                    _searchQueue.Enqueue(current.Left);
                }
                else
                {
                    return current;
                }
            }
            return null;
        }
    }
}