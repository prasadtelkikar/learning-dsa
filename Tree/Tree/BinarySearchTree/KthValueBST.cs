using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.BinarySearchTree
{
    public class KthValueBST
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 5, 3, 7, 1, 4, 6, 8, null, 2 });
            int k = 3;
            (int smallest, int largest) = FindKthSmallestLargestFromBST(root, k);
            Console.WriteLine($"Smallest = {smallest} Largest = {largest}");
            Console.ReadLine();
        }

        private static (int smallest, int largest) FindKthSmallestLargestFromBST(TreeNode? root, int k)
        {
            List<int> inOrderList = new List<int>();
            InOrderTraversalToGetList(root, inOrderList);

            int smallestValue = inOrderList[k-1];
            int largestValue = inOrderList[inOrderList.Count - k];
            return (smallestValue, largestValue);
        }

        private static void InOrderTraversalToGetList(TreeNode? root, List<int> inOrderList)
        {
            if(root != null)
            {
                InOrderTraversalToGetList(root.Left, inOrderList);
                inOrderList.Add(root.Value);
                InOrderTraversalToGetList(root.Right, inOrderList);
            }
        }
    }
}
