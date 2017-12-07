using dotnetREST.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.CollatedTree
{
    public class TreeNode : IDisposable
    {

        private TreeNode _Parent;
        private TreeNodeList _Children;
        private string _Value;

        public TreeNode(string Value)
        {
            this.Value = Value;
            Children = new TreeNodeList(this);
        }


        //public TreeNode Parent
        //{
        //    get { return _Parent; }
        //    set
        //    {
        //        if (value == _Parent)
        //        {
        //            return;
        //        }
        //        if (_Parent != null)
        //        {
        //            _Parent.Children.Remove(this);
        //        }
        //        if (value != null && !value.Children.Contains(this))
        //        {
        //            value.Children.Add(this);
        //        }
        //        _Parent = value;
        //    }
        //}


        public TreeNodeList Children
        {
            get { return _Children; }
            private set { _Children = value; }
        }


        public string Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
