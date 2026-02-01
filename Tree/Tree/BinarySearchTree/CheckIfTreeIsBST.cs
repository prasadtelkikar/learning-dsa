using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class CheckIfTreeIsBST
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 2, 1, 3, null, null, null, 5 });
            bool isBST = IsTreeBSTRecursive(root, int.MinValue, int.MaxValue);
            Console.WriteLine(isBST ? "Tree is BST" : "Tree is not BST");
            Console.ReadLine();
        }
                 
        private static bool IsTreeBSTRecursive(TreeNode? root, int minValue, int maxValue)
        {
            if (root == null)
                return true;

            if (root.Value < minValue || root.Value > maxValue) return false;

            return IsTreeBSTRecursive(root.Left, minValue, root.Value - 1)
                && IsTreeBSTRecursive(root.Right, root.Value + 1, maxValue);
        }

        public static bool InOrderBSTNonRecursive(TreeNode? root, ref int prev)
        {
            if (root == null)
                return true;

            if(!InOrderBSTNonRecursive(root.Left, ref prev))
                return false;

            if (prev >= root.Value)
                return false;
            prev = root.Value;

            return InOrderBSTNonRecursive(root.Right, ref prev);
        }

        //Morris Traversal... TODOD
    }
}
