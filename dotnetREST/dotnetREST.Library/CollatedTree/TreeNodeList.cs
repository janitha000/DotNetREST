using dotnetREST.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.CollatedTree
{
    public class TreeNodeList 
    {
        public TreeNode Parent;
        private Dictionary<int, List<PrintJob>> _printjobs;

        public TreeNodeList(TreeNode Parent)
        {
            this.Parent = Parent;
            _printjobs = new Dictionary<int, List<PrintJob>>();
        }

        public new List<PrintJob>  Add(int key, List<PrintJob> printJobs)
        {
            _printjobs.Add(key, printJobs);
            //Node.Parent = Parent;
            return printJobs;
        }

        public void AddValue(int key, PrintJob printJob)
        {
            _printjobs.TryGetValue(key, out List<PrintJob> list);
            list.Add(printJob);

            _printjobs[key] = list;
        }
    }
}
