using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class InsertNodeIntoBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 40, 20, 60, 10, 30, 50, 70 });
            int newNodeValue = 25;

            TreeNode? newRoot = InsertNodeToBST(root, newNodeValue);
            Console.ReadLine();
        }

        private static TreeNode? InsertNodeToBST(TreeNode? root, int newNodeValue)
        {
            if (root == null)
               return new TreeNode(newNodeValue);

            if(newNodeValue < root.Value)
                root.Left = InsertNodeToBST(root.Left, newNodeValue);
            else
                root.Right = InsertNodeToBST(root.Right, newNodeValue);

            return root;
        }

        private static TreeNode? InsertNodeToBSTNonRecursive(TreeNode? root, int newNodeValue)
        {
            if (root == null)
                return new TreeNode(newNodeValue);

            TreeNode current = root;
            while (true)
            {
                if(newNodeValue < current.Value)
                {
                    if(current.Left == null)
                    {
                        current.Left = new TreeNode(newNodeValue);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if(current.Right == null)
                    {
                        current.Right = new TreeNode(newNodeValue);
                        break;
                    }
                    current = current.Right;
                }
            }
            return root;
        }
    }
}
