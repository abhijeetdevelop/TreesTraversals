using System;
using System.Collections.Generic;

namespace TreesTraversals
{
    public class TreeNode
    {
        public TreeNode left, right;
        public int val;

        public TreeNode(int val)
        {
            this.val = val;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode input = new TreeNode(5); //Root 
            input.left = new TreeNode(3);
            input.left.left = new TreeNode(1);
            input.right = new TreeNode(7);
            input.right.left = new TreeNode(6);

            List<int> inList = new List<int>();
            InOrder(input, inList);

            Console.WriteLine("Hello World!");
        }

        private static void PreOrder(TreeNode input, List<int> preList)
        {
            if (input == null)
                return;

            preList.Add(input.val);
            PreOrder(input.left, preList);
            PreOrder(input.right, preList);
        }
        private static void InOrder(TreeNode input, List<int> inList)
        {
            if (input == null)
                return;

            InOrder(input.left, inList);
            inList.Add(input.val);
            InOrder(input.right, inList);
        }
       
        private static void PostOrder(TreeNode input, List<int> postList)
        {
            if (input == null)
                return;

            PostOrder(input.left, postList);           
            PostOrder(input.right, postList);
            postList.Add(input.val);
        }
    }
}
