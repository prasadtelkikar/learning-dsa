using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class LeastCommonAncestorInBST
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 20, 8, 22, 4, 12, null, null, 10, 14 });
            TreeNode lca = FindLeastCommonAncestorInBST(root, new TreeNode(4), new TreeNode(14));
        }
        private static TreeNode FindLeastCommonAncestorInBST(TreeNode? root, TreeNode treeNode1, TreeNode treeNode2)
        {
            if(root == null)
                return null;

            if (root.Value > treeNode1.Value && root.Value > treeNode2.Value)
                return FindLeastCommonAncestorInBST(root.Left, treeNode1, treeNode2);
            if(root.Value < treeNode1.Value && root.Value < treeNode2.Value)
                return FindLeastCommonAncestorInBST(root.Right, treeNode1, treeNode2);

            return root;
        }

        private static TreeNode? FindLCANonRecursively(TreeNode? root, TreeNode treeNode1, TreeNode treeNode2)
        {
            while(root != null)
            {
                if (root.Value > treeNode1.Value && root.Value > treeNode2.Value)
                    root = root.Left;
                else if (root.Value < treeNode1.Value && root.Value < treeNode2.Value)
                    root = root.Right;
                else break;
            }
            return root;
        }
    }
}
