using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.CollatedTree
{
    public class CollatedTree : ICollatedTree
    {
        private readonly Dictionary<string , TreeNode > _tree;

        public CollatedTree(Dictionary<string, TreeNode> tree)
        {
            _tree = tree;
        }


    }
}
