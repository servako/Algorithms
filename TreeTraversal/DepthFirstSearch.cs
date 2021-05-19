using System.Collections.Generic;

namespace TreeTraversal
{
    public class DepthFirstSearch
    {
        private Stack<BinaryTreeNode> _searchStack;
        public DepthFirstSearch()
        {
            _searchStack = new Stack<BinaryTreeNode>();
        }

        public bool Search(BinaryTreeNode rootNode, int data)
        {
            BinaryTreeNode current;
            _searchStack.Push(rootNode);
            while (_searchStack.Count != 0)
            {
                current = _searchStack.Pop();
                if (current.Data == data)
                {
                    return true;
                }
                else
                {
                    _searchStack.Push(current.Right);
                    _searchStack.Push(current.Left);
                }
            }
            return false;
        }
    }
}