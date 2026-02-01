using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class LeftViewBinaryTreeTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, 6, 5, 8, 4 });
            List<int> result = LeftTreeTraversal(root);
            Console.WriteLine(String.Join(", ", result));
            Console.ReadKey();
        }

        private static List<int> LeftTreeTraversal(TreeNode? root)
        {
            List<int> result = new List<int>();
            SortedDictionary<int, List<int>> map = new SortedDictionary<int, List<int>>();
            int level = 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null)
                return result;

            queue.Enqueue(root!);
            while(queue.Count > 0)
            {
                var size = queue.Count;
                for(int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if(!map.ContainsKey(level))
                        map[level] = new List<int>();

                    map[level].Add(node.Value);
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
                level++;
            }

            foreach (var kvp in map)
                result.Add(kvp.Value.First()); //If we use `.Last()` then it will be right view

            return result;
        }

        private void LeftTreeTraversal(TreeNode? root, int level, List<int> result)
        {
            if (root == null)
                return;

            if(level == result.Count)
                result.Add(root.Value);

            LeftTreeTraversal(root.Left, level + 1, result);  //Instead of Left, if we traverse right first, then it will be right view.
            LeftTreeTraversal(root.Right, level + 1, result);
        }
    }
}
