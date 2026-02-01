using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class VerticalTreeTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, 4, 10, 9, 11, null, 5, null, null, null, null, null, null, null, 6 });

            List<List<int>> result = VerticalTreeTraversalFunc(root);
            foreach (var col in result)
            {
                Console.Write("[ ");
                Console.WriteLine(String.Join(" ", col));
                Console.Write("]");
            }
        }

        private static List<List<int>> VerticalTreeTraversalFunc(TreeNode? root)
        {
            List<List<int>> result = new List<List<int>>();

            SortedDictionary<int, List<int>> verticalOrderNodes = new SortedDictionary<int, List<int>>();
            Queue<(TreeNode node, int col)> queue = new Queue<(TreeNode node, int col)>();

            if (root is null)
                return result;

            queue.Enqueue((root, 0));

            while(queue.Count > 0)
            {
                var (node, col) = queue.Dequeue();

                if(!verticalOrderNodes.ContainsKey(col))
                    verticalOrderNodes[col] = new List<int>();

                verticalOrderNodes[col].Add(node.Value);
                if (node.Left != null)
                    queue.Enqueue((node.Left, col - 1));

                if (node.Right != null)
                    queue.Enqueue((node.Right, col + 1));
            }

            foreach (var kvp in verticalOrderNodes)
                result.Add(kvp.Value);

            return result;
        }
    }
}
