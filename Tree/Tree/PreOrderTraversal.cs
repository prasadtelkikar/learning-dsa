using Tree.Helper;

namespace Tree
{
    internal class PreOrderTraversal
    {
        static void Main(string[] args)
        {
            TreeNode? root = TreeBuilder.BuildTreeWithLevelOrder(new int?[] { 4, 2, 5, 3, null, 7, 6, null, 9, null, null, 8, null, 1 });
            List<int?> result = new List<int?>();
            PreOrder(root, result);
            Console.WriteLine(string.Join(", ", result));


            var resultPreOder = PreOrder(root);
            Console.WriteLine(string.Join(", ", resultPreOder));

            Console.ReadLine();
        }

        private static void PreOrder(TreeNode? root, List<int?> result)
        {
            if (root == null)
                return;

            result.Add(root.Value);
            PreOrder(root.Left, result);
            PreOrder(root.Right, result);
        }

        private static IList<int> PreOrder(TreeNode? root)
        {
            List<int> result = new List<int>();
            if (root == null) return result;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                var node = stack.Pop();
                result.Add(node.Value);

                if(node.Right != null)
                    stack.Push(node.Right);

                if(node.Left != null)
                    stack.Push(node.Left);
            }

            return result;
        }
    }
}