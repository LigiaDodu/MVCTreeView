using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeView.Models
{
    public class ProfileTreeViewItem
    {
        public Profile Root { get; set; }
        public IEnumerable<ProfileTreeViewItem> Childrens { get; set; }

        public ProfileTreeViewItem(Profile test, IEnumerable<ProfileTreeViewItem> children)
        {
            Root = test;
            Childrens = children;
        }

        public ProfileTreeViewItem(Profile test)
        {
            Root = test;
        }

    }
}