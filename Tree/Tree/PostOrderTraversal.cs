using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree
{
    public class PostOrderTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 4, 2, 5, 3, null, 7, 6, null, 9, null, null, 8, null, 1 });
            List<int?> result = new List<int?>();
            PostOrder(root, result);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();
        }

        private static void PostOrder(TreeNode? root, List<int?> result)
        {
            if (root == null)
                return;

            PostOrder(root.Left, result);
            PostOrder(root.Right, result);
            result.Add(root.Value);
        }

        private static List<int> PostOrder(TreeNode? root)
        {
            if (root == null)
                return new List<int>();

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();
            List<int> result = new List<int>();
            stack1.Push(root);

            while(stack1.Count > 0)
            {
                var temp = stack1.Pop();
                stack2.Push(temp);

                if(temp.Left != null)
                    stack1.Push(temp.Left);

                if(temp.Right != null)
                    stack1.Push(temp.Right);
            }

            while(stack2.Count > 0)
            {
                result.Add(stack2.Pop().Value);
            }

            return result;
        }
    }
}
