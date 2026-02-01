using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class FindLowestCommonAncestor
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
            int p = 5;
            int q = 1;

            TreeNode result = LowestCommonAncestor(root, p, q);
            Console.WriteLine(result?.Value);
            Console.ReadLine();
        }

        private static TreeNode? LowestCommonAncestor(TreeNode? root, int p, int q)
        {
            if (root == null || root.Value == p || root.Value == q)
                return root;

            TreeNode? left = LowestCommonAncestor(root.Left, p, q);
            TreeNode? right = LowestCommonAncestor(root.Right, p, q);

            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
                return root;


        }
    }
}
