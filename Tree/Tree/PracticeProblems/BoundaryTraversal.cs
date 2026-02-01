using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class BoundaryTraversal
    {
        public static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 1, 2, 7, 3, null, null, 8, null, 4, 9, null, 5, 6, 10, 11 });
            List<int> result = BoundaryTreeTraversal(root);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();
        }

        private static List<int> BoundaryTreeTraversal(TreeNode? root)
        {
            var result = new List<int>();
            if (root is null)
                return result;
            result.Add(root.Value);

            result.AddRange(GetLeftBoundary(root));
            GetLeafNode(root, result);
            var rightBoundary = GetRigthBoundary(root);
            rightBoundary.Reverse();
            result.AddRange(rightBoundary);

            return result;
        }

        private static List<int> GetLeftBoundary(TreeNode root)
        {
            var current = root.Left;
            var result = new List<int>();
            while(current is not null)
            {
                if (!IsLeafNode(current))
                    result.Add(current.Value);
                if (current.Left is not null)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return result;
        }

        private static List<int> GetRigthBoundary(TreeNode root)
        {
            var current = root.Right;
            List<int> result = new List<int>();
            while(current is not null)
            {
                if (!IsLeafNode(current))
                    result.Add(current.Value);

                if(current.Right is not null)
                    current = current.Right;
                else current = current.Left;
            }
            return result;
        }

        private static void GetLeafNode(TreeNode? root, List<int> result)
        {
            if (IsLeafNode(root))
            {
                result.Add(root!.Value);
                return;
            }

            if(root?.Left is not null)
                GetLeafNode(root!.Left, result);
            if(root?.Right is not null)
                GetLeafNode(root!.Right, result);
        }

        private static bool IsLeafNode(TreeNode? root) => root is not null && root.Left is null && root.Right is null;
    }
}
