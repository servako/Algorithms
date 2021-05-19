using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new BinaryTreeNode(7);
            var node0 = new BinaryTreeNode(0);
            var node_3 = new BinaryTreeNode(-3);
            var node_4 = new BinaryTreeNode(-4);
            var node_1 = new BinaryTreeNode(-1);
            var node_5 = new BinaryTreeNode(-5);
            var node_2 = new BinaryTreeNode(-2);
            var node8 = new BinaryTreeNode(8);
            var node2 = new BinaryTreeNode(2);
            var node4 = new BinaryTreeNode(4);

            rootNode.Left = node0;
            rootNode.Right = node8;
            node0.Left = node_3;
            node_3.Left = node_4;
            node_3.Right = node_1;
            node_4.Left = node_5;
            node_4.Right = node_2;
            node8.Right = node2;
            node2.Right = node4;

            var recursiveSearch = new RecursiveSearch();
            var resultRecursive = recursiveSearch.FindCommonAncessor(rootNode, -4,-1);
            Console.WriteLine($"Recursive search {resultRecursive.Data}");

            var breadthFirstSearch = new BreadthFirstSearch();
            var resultBreadthFirstSearch = breadthFirstSearch.Search(rootNode, -4, -1);
            Console.WriteLine($"BreadthFirstSearch search: {resultBreadthFirstSearch.Data}");

            var depthFirstSearch = new DepthFirstSearch();
            var resultDepthFirstSearch = depthFirstSearch.Search(rootNode, -3);
            Console.WriteLine($"DepthFirstSearch found: {resultDepthFirstSearch}");

            Console.WriteLine("Hello World!");
        }
    }
}
