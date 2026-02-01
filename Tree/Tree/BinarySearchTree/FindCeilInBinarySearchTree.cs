using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class FindCeilInBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 10, 5, 15, 2, 6, null, null });
            int key = 7;

            var result = GetCeilValue(root, key);
            Console.WriteLine(result);
        }

        private static int GetCeilValue(TreeNode? root, int key)
        {
            int result = 0;

            while(root != null)
            {
                if (root.Value == key)
                    return key;
                if(key < root.Value)
                {
                    result = root.Value;
                    root = root.Left;
                }
                else
                    root = root.Right;
            }
            return result;
        }
    }
}
