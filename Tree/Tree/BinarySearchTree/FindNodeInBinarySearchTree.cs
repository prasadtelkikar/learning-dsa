using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class FindNodeInBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 8, 5, 12, 4, 7, 10, 14, null, null, 6, null, null, null, 13, null });
            int key = 10;

            bool found = FindInBinaryTree(root, key);
            Console.WriteLine(found ? "Node found" : "Node did not find");
            Console.ReadLine();
        }

        private static bool FindInBinaryTree(TreeNode? root, int key)
        {
            while(root != null || root.Value == key)
            {
                if (key < root.Value)
                    root = root.Left;
                else
                    root = root.Right;
            }

            return root != null;
        }
    }
}
