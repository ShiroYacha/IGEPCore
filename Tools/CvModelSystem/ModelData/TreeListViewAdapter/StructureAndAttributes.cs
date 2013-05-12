using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing;
using System.Reflection;
// EmguCV
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public delegate void TreeVisitor<TData>(TreeNode<TData> parent, TData nodeData);

    public class TreeNode<TData>
    {
        private TData data;

        private TreeNode<TData> parent;
        private LinkedList<TreeNode<TData>> children;

        public TreeNode(TData data, TreeNode<TData> parent)
        {
            this.data = data;
            this.parent = parent;
            children = new LinkedList<TreeNode<TData>>();
        }

        public TData Data { get { return data; } }

        public void addChild(TData data, TreeNode<TData> parent)
        {
            children.AddFirst(new TreeNode<TData>(data, parent));
        }

        public void addChild(TreeNode<TData> node)
        {
            children.AddFirst(node);
        }

        public TreeNode<TData> getParent()
        {
            return parent;
        }

        public TreeNode<TData> getChild(int i)
        {
            foreach (TreeNode<TData> node in children)
                if (--i == 0) return node;
            return null;
        }

        public LinkedList<TreeNode<TData>> getChildren()
        {
            return children;
        }

        public void traverse(TreeVisitor<TData> visitor)
        {

            visitor(this.parent, this.data);
            foreach (TreeNode<TData> kid in this.children)
                kid.traverse(visitor);
        }
    }

    public enum ComponentNature { Root, Node, Leaf };

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ComponentDataAttribute : Attribute
    {
        private ComponentNature status;
        public ComponentNature Status { get { return status; } }
        public ComponentDataAttribute(ComponentNature status)
        {
            this.status = status;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
    public class ComponentBuildAttribute : Attribute
    {
        private ComponentNature status;
        public ComponentNature Status { get { return  status; } }
        public ComponentBuildAttribute(ComponentNature status)
        {
            this.status = status;
        }
    }

}
