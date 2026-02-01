using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Helper
{
    public class TreeNode
    {
        public readonly int Value;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int val, TreeNode? left = null, TreeNode? right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }

        public override bool Equals(object node2)
        {
            return node2 is TreeNode nodeObj && this.Value == nodeObj.Value;
        }
    }
}
