using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.AdvancedTreeProblems
{
    public class RootToNNodePath
    {
        public static void Main(string[] args)
        {
            int node = 7;
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 3, 4, 5, null, null, null, null });

            List<int> result = FindPath(root, node);

            Console.WriteLine(String.Join(", ", result));
            Console.ReadLine();
        }

        private static List<int> FindPath(TreeNode? root, int node)
        {
            List<int> storage = new List<int>();
            if(root == null)
                return storage;

            GetPath(root, storage, node);
            return storage;
        }

        private static bool GetPath(TreeNode? root, List<int> storage, int value)
        {
            if (root == null)
                return false;

            storage.Add(root.Value);

            if (root.Value == value)
                return true;

            if (GetPath(root.Left, storage, value) || GetPath(root.Right, storage, value))
                return false;

            storage.RemoveAt(storage.Count - 1);
            return false;
        }
    }
}
