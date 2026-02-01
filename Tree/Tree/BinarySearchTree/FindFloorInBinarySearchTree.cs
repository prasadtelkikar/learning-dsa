using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class FindFloorInBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 10, 5, 15, 2, 6, null, null });
            int key = 7;

            var result = GetFloorInBST(root, key);
            Console.WriteLine(result);
        }

        private static int GetFloorInBST(TreeNode? root, int key)
        {
            int result = 0;
            while(root != null)
            {
                if(key < root.Value)
                {
                    root = root.Left;
                }
                else
                {
                    result = root.Value;
                    root = root.Right;
                }
            }

            return result;
        }
    }
}
