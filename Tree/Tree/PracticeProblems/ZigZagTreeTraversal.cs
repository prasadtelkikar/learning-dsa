using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class ZigZagTreeTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, 4, 5, null, 6 });
            List<List<int>> result = CreateZigzagTreeTraversal(root);
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in result)
                sb.Append($"[ {string.Join(", ", item)} ], ");
            sb.Append("]");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }

        private static List<List<int>> CreateZigzagTreeTraversal(TreeNode? root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var leftToRightTraversal = true;
            while (queue.Count > 0)
            {
                List<int> level = new List<int>();
                int length = queue.Count;

                for(int i = 0; i < length; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.Left is not null)
                        queue.Enqueue(node.Left);
                    if (node.Right is not null)
                        queue.Enqueue(node.Right);

                    level.Add(node.Value);
                }
                if (!leftToRightTraversal)
                    level.Reverse();

                leftToRightTraversal = !leftToRightTraversal;
                result.Add(level);
            }

            return result;
        }
    }
}
