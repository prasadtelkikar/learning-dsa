using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree
{
    public class InOrderTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[]{ 1, 4, null, 4, 2});

            List<int> list = new List<int>();
            InOrder(root, list);
            Console.WriteLine(string.Join(", ", list));

            var resultList = InOrderNonRecursive(root);
            Console.WriteLine(string.Join(", ", resultList));
            Console.ReadLine();
        }

        private static void InOrder(TreeNode? root, List<int> list)
        {
            if (root == null)
                return;

            InOrder(root.Left, list);
            list.Add(root.Value);
            InOrder(root.Right, list);
        }

        private static List<int> InOrderNonRecursive(TreeNode? root)
        {
            List<int> result = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode? currentNode = root;

            while(currentNode != null || stack.Count > 0)
            {
                while(currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();
                result.Add(currentNode.Value);

                currentNode = currentNode.Right;
            }

            return result;
        }
    }
}
