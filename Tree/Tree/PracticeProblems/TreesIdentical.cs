using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class TreesIdentical
    {
        public static void Main(string[] args)
        {
            TreeNode? firstRoot = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, null, null, 4, 5 });
            
            TreeNode? secondRoot = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, null, null, 4, 5 });

            var identical = IsIdentical(firstRoot, secondRoot);

            Console.WriteLine(identical ? "Both trees are identical" : "Both trees are not identical");
            Console.ReadLine();
        }

        private static bool IsIdentical(TreeNode? firstRoot, TreeNode? secondRoot)
        {
            if (firstRoot == null && secondRoot == null)
                return true;

            if(firstRoot == null || secondRoot == null)
                return false;

            var identical = firstRoot.Equals(secondRoot) 
                && IsIdentical(firstRoot.Left, secondRoot.Left) 
                && IsIdentical(firstRoot.Right, secondRoot.Right);

            return identical;
        }


    }
}
