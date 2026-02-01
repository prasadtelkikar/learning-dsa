using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class MaxSumPathInTree
    {
        private static int _maxSum = 0;

        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { -10, 9, 20, null, null, 15, 7 });
            FindMaxSum(root);
            Console.WriteLine($"Max sum = {_maxSum}");
            Console.ReadLine();
        }

        private static int FindMaxSum(TreeNode? root)
        {
            if(root == null)
                return 0;

            int leftSum = FindMaxSum(root.Left);
            int rightSum = FindMaxSum(root.Right);

            _maxSum = Math.Max(_maxSum, leftSum + rightSum + root.Value);
            return leftSum + rightSum + root.Value;
        }
    }
}
