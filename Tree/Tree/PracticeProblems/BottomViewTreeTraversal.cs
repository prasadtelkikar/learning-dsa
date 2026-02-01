using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class BottomViewTreeTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 2, 7, 5, 2, 6, null, 9, null, null, 5, 11, 4, null });
            var result = FindBottomViewOfTree(root);

            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }

        private static List<int> FindBottomViewOfTree(TreeNode? root)
        {
            var result = new List<int>();
            SortedDictionary<int, List<int>> map = new SortedDictionary<int, List<int>>();
            Queue<(TreeNode node, int col)> queue = new Queue<(TreeNode node, int col)> ();

            if (root is null)
                return result;

            queue.Enqueue((root, 0));
            while(queue.Count > 0)
            {
                var (node, col) = queue.Dequeue ();
                if(!map.ContainsKey(col))
                    map[col] = new List<int>();

                map[col].Add(node.Value);

                if(node.Left != null)
                    queue.Enqueue((node.Left, col-1));
                if(node.Right != null)
                    queue.Enqueue((node.Right, col+1));
            }

            foreach (var kvp in map)
                result.Add(kvp.Value.OrderByDescending(x => x).Last());

            return result;
        }
    }
}
