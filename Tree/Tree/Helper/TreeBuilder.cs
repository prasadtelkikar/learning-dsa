using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Helper
{
    public static class TreeBuilder
    {
        public static TreeNode? BuildTreeWithLevelOrder(int?[] values)
        {
            if(values == null || values.Length == 0 || !values[0].HasValue)
                return null;

            TreeNode root = new TreeNode(values[0]!.Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while(i < values.Length)
            {
                TreeNode current = queue.Dequeue();
                //Process left node
                if(i < values.Length && values[i] != null)
                {
                    current.Left = new TreeNode(values[i]!.Value);
                    queue.Enqueue(current.Left);
                }
                i++; //Increment counter if item is processed or there is null entry

                if(i < values.Length && values[i] != null)
                {
                    current.Right = new TreeNode(values[i]!.Value);
                    queue.Enqueue(current.Right);
                }
                i++;
            }

            return root;
        }
    }
}
