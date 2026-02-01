using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class HeightOfTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 5, null, null, 4, 6, 5 });
            
            int result = FindHeightOfTree(root);
            Console.WriteLine(result);
            Console.ReadLine();     
        }

        private static int FindHeightOfTree(TreeNode? root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 0;
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                int size = queue.Count;
                for(int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();

                    if(node.Left != null)
                        queue.Enqueue(node.Left);
                    if(node.Right != null)
                        queue.Enqueue(node.Right);
                }
                level++;
            }

            return level;
        }
    }
}
