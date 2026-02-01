using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class FindTreeIsBalanced
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, null, null, 4, 5 });
            int height = FindHeight(root);

            Console.WriteLine(height != -1 ? "Tree is balanced" : "Tree is not balanced" );
            Console.ReadKey();
        }

        private static int FindHeight(TreeNode? root)
        {
            if(root == null)
                return 0;

            int leftHeight = FindHeight(root.Left);
            int rightHeight = FindHeight(root.Right);

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
