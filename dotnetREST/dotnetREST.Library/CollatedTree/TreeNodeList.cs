using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.CollatedTree
{
    public class TreeNodeList : List<TreeNode>
    {
        public TreeNode Parent;
        public TreeNodeList(TreeNode Parent)
        {
            this.Parent = Parent;
        }

        public new TreeNode Add(TreeNode Node)
        {
            base.Add(Node);
            Node.Parent = Parent;
            return Node;
        }

        public TreeNode Add(T Value)
        {
            return Add(new TreeNode(Value));
        }
    }
}
