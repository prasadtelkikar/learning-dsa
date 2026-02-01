using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree.Helper;

namespace Tree.PracticeProblems
{
    public class FindDiameterOfTree
    {
        private static int _diameter = 0;
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Left.Right.Right = new TreeNode(6);
            root.Left.Right.Right.Right = new TreeNode(7);

            DiameterOfTree(root);

            Console.WriteLine("Diameter of the tree " + _diameter);
            Console.ReadLine();

        }

        private static int DiameterOfTree(TreeNode? root)
        {
            if (root == null)
                return 0;

            int leftHieght = DiameterOfTree(root?.Left);
            int rightHieght = DiameterOfTree(root?.Right);

            _diameter = Math.Max(_diameter, (leftHieght + rightHieght));

            return Math.Max(leftHieght, rightHieght) + 1;
        }
    }
}
