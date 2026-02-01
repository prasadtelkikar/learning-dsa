using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class DeleteNodeFromBinarySearchTree
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 50, 30, 70, 20, 40, 60, 80});
            int deletingNodeValue = 50;
            TreeNode? updatedRoot = DeleteNodeFromBST(root, deletingNodeValue);

            Console.ReadLine();
        }

        private static TreeNode? DeleteNodeFromBST(TreeNode? root, int key)
        {
            if (root == null)
                return null;
            //Go till that element
            if(key < root.Value)
                root.Left = DeleteNodeFromBST(root.Left, key);
            else if(key > root.Value)
                root.Right = DeleteNodeFromBST(root.Right, key);
            else
            {
                //This is where match found, if its right empty just replace with the left or vice versa.
                if (root.Right == null)
                    return root.Left;
                if (root.Left == null)
                    return root.Right;

                //Find smallest element and remove that from the tree
                TreeNode smallestNodeOnRight = FindSmallestElementOnRight(root.Right);
                //We need to replace only value... As Value is readonly in my structure I am creating new instance
                root = new TreeNode(smallestNodeOnRight.Value, root.Left, root.Right);
                root.Right = DeleteNodeFromBST(root.Right, smallestNodeOnRight.Value); //THIS IS EPIC AS IT DELETE THE SMALLEST NODE.
            }

            return root;
        }

        private static TreeNode FindSmallestElementOnRight(TreeNode right)
        {
            while(right.Left != null)
                right = right.Left;
            return right;
        }
    }
}
