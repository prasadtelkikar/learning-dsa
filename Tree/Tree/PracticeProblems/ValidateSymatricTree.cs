using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class ValidateSymatricTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 2, 3, 4, 4, 3 });
            bool isSymmetric = IsTreeSymmatric(root);
            Console.WriteLine(isSymmetric ? "Tree is symmetric" : "Tree is not symmetric");
            Console.ReadLine();
        }

        private static bool IsBothSymmatric(TreeNode? leftTree, TreeNode? rightTree)
        {
            
            if(leftTree == null || rightTree == null)
                return leftTree == rightTree;

            return (leftTree.Value == rightTree.Value) 
                && IsBothSymmatric(leftTree.Left, rightTree.Right)
                && IsBothSymmatric(leftTree.Right, rightTree.Left);
        }

        private static bool IsTreeSymmatric(TreeNode? root)
        {
            if (root == null)
                return true;

            return IsBothSymmatric(root.Left, root.Right);
        }
    }
}
