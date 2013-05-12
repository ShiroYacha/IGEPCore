using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
// EmguCV
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public interface IComponentDataTreeRoot
    {
        IComponentDataTreeAdapter ComponentAdapter { get; set; }
    }

    public interface IComponentDataTreeAdapter
    {
        void RefreshTree();
        void BuildTree();
        void DiscoveryComponentTreeNode();
        void DiscoveryComponentTreeLeaf(string nodeKey);
    }

    public class TreeAndListViewAdapter : IComponentDataTreeAdapter
    {
        private string lastNodeKey;

        private object componentTreeRoot;
        private TreeNode<string> treeNodeRoot;
        private Dictionary<string, List<Tuple<string, string>>> treeLeafDict;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;

        public TreeAndListViewAdapter(object componentTreeRoot, System.Windows.Forms.TreeView treeView, System.Windows.Forms.ListView listView, string lastNodeKey)
        {
            this.componentTreeRoot = componentTreeRoot;
            this.treeView = treeView;
            this.listView = listView;
            this.lastNodeKey = lastNodeKey;
        }

        public void DiscoveryComponentTreeNode()
        {
            // Update tree view
            treeView.Nodes.Clear();
            treeNodeRoot.traverse(
                (parent, nodeData) =>
                {
                    System.Windows.Forms.TreeNode childNode = new System.Windows.Forms.TreeNode();
                    childNode.Text = nodeData;
                    childNode.Name = nodeData;
                    if (parent != null)
                    {
                        if (nodeData.Contains("(collection)"))
                        {
                            // Set image :green cube for collection child
                            childNode.ImageIndex = 2;
                            childNode.SelectedImageIndex = 2;
                        }
                        else
                        {
                            // Set image :blue cube for default child
                            childNode.ImageIndex = 1;
                            childNode.SelectedImageIndex = 1;
                        }
                        // Add to parent node
                        System.Windows.Forms.TreeNode[] parentNode = treeView.Nodes.Find(parent.Data, true);
                        parentNode[0].Nodes.Add(childNode);
                    }
                    else
                    {
                        // Set image :black cube for default root
                        childNode.ImageIndex = 0;
                        childNode.SelectedImageIndex = 0;
                        // Add to tree
                        treeView.Nodes.Add(childNode);
                    }
                }
             );
            treeView.Refresh();
            treeView.ExpandAll();
            // Clear list view
            if (lastNodeKey != null) DiscoveryComponentTreeLeaf(lastNodeKey);
        }

        public void DiscoveryComponentTreeLeaf(string nodeKey)
        {
            // Update list view
            listView.Items.Clear();
            if (treeLeafDict.ContainsKey(nodeKey))
            {
                foreach (Tuple<string, string> info in treeLeafDict[nodeKey])
                {
                    ListViewItem item = new ListViewItem(new string[]{info.Item1, info.Item2});
                    item.Name = info.Item1;
                    listView.Items.Add(item);
                }
            }
        }

        private void CreateTreeNode(TreeNode<string> componentTreeNode, object componentTreeNodeObject)
        {
            // Get all component nodes
            List<ComponentNature> component = new List<ComponentNature>();
            // Check for fields
            FieldInfo[] fieldComponents = componentTreeNodeObject.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.FlattenHierarchy)
                .Where<FieldInfo>(
                    (fieldInfo) =>
                    {
                        object[] attributes = fieldInfo.GetCustomAttributes(typeof(ComponentDataAttribute), false);
                        if (attributes.Length == 0)
                        {
                            return false;
                        }
                        else
                        {
                            component.Add(((ComponentDataAttribute)attributes[0]).Status);
                            return true;
                        }
                    }
                ).ToArray();
            // Check for properties
            PropertyInfo[] propertyComponents = componentTreeNodeObject.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                .Where<PropertyInfo>(
                    (propertyInfo) =>
                    {
                        object[] attributes = propertyInfo.GetCustomAttributes(typeof(ComponentDataAttribute), false);
                        if (attributes.Length == 0)
                        {
                            return false;
                        }
                        else
                        {
                            component.Add(((ComponentDataAttribute)attributes[0]).Status);
                            return true;
                        }
                    }
                ).ToArray();
            // Iterate and add to children nodes
            for (int i = 0; i < fieldComponents.Length+propertyComponents.Length; i++)
            {
                object nodeObject;
                string keyName=string.Empty;
                if (i < fieldComponents.Length)
                {
                    nodeObject = fieldComponents[i].GetValue(componentTreeNodeObject);
                    if (nodeObject != null) keyName = nodeObject.GetType().Name + " : " + fieldComponents[i].Name;
                }
                else
                {
                    nodeObject = propertyComponents[i - fieldComponents.Length].GetValue(componentTreeNodeObject, null);
                    if (nodeObject != null) keyName = nodeObject.GetType().Name + " : " + propertyComponents[i - fieldComponents.Length].Name;
                }
                if (nodeObject != null)
                {
                    if (nodeObject is IEnumerable && !(nodeObject is String) )
                    {
                        // Create collection node
                        keyName = nodeObject.GetType().Name + " : " + fieldComponents[i].Name.TrimEnd('s') + "(collection)";
                        TreeNode<string> collectionNode = new TreeNode<string>(keyName, componentTreeNode);
                        componentTreeNode.addChild(collectionNode);
                        // Custom classes
                        int count = 0; 
                        foreach (object item in nodeObject as IEnumerable)
                        {
                            keyName = item.GetType().Name + " : " + fieldComponents[i].Name.TrimEnd('s') + "#" + count++;
                            // Native leaf element
                            if (!CreateNativeLeaves(keyName, item, collectionNode.Data))
                            {
                                // Common node element
                                if (component[i] == ComponentNature.Node)
                                {
                                    // Create tree node and add to tree
                                    TreeNode<string> node = new TreeNode<string>
                                        (keyName, collectionNode);
                                    collectionNode.addChild(node);
                                    CreateTreeNode(node, item);
                                }
                                // Common leaf element
                                else if (component[i] == ComponentNature.Leaf)
                                {
                                    Tuple<string, string> info = new Tuple<string, string>(keyName, item.ToString());
                                    if (!treeLeafDict.ContainsKey(collectionNode.Data))
                                    {
                                        // Add to tree dictionary
                                        List<Tuple<string, string>> infoList = new List<Tuple<string, string>>();
                                        infoList.Add(info);
                                        treeLeafDict.Add(collectionNode.Data, infoList);
                                    }
                                    else
                                    {
                                        // Add to list
                                        treeLeafDict[collectionNode.Data].Add(info);
                                    }
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        if (component[i] == ComponentNature.Node)
                        {
                            // Create tree node and add to tree
                            TreeNode<string> node = new TreeNode<string>
                                (keyName, componentTreeNode);
                            componentTreeNode.addChild(node);
                            CreateTreeNode(node, nodeObject);
                        }
                        else
                        {
                            Tuple<string, string> info = new Tuple<string, string>(keyName, nodeObject.ToString());
                            if (!treeLeafDict.ContainsKey(componentTreeNode.Data))
                            {
                                // Add to tree dictionary
                                List<Tuple<string, string>> infoList = new List<Tuple<string, string>>();
                                infoList.Add(info);
                                treeLeafDict.Add(componentTreeNode.Data, infoList);
                            }
                            else
                            {
                                // Add to list
                                treeLeafDict[componentTreeNode.Data].Add(info);
                            }
                        }
                    }
                }
 
            }
        }

        private bool CreateNativeLeaves(string keyName, object item,string dictKey)
        {
            Tuple<string, string> info=null;
            if (item.GetType() == typeof(int))
            {
                int intItem = (int)item;
                info = new Tuple<string, string>(keyName, intItem.ToString());
            }
            else if (item.GetType() == typeof(Microsoft.Xna.Framework.Vector2))
            {
                Microsoft.Xna.Framework.Vector2 vectorItem = (Microsoft.Xna.Framework.Vector2)item;
                info = new Tuple<string, string>(keyName, vectorItem.ToString());

            }
            if (info != null)
            {
                if (!treeLeafDict.ContainsKey(dictKey))
                {
                    // Add to tree dictionary
                    List<Tuple<string, string>> infoList = new List<Tuple<string, string>>();
                    infoList.Add(info);
                    treeLeafDict.Add(dictKey, infoList);
                }
                else
                {
                    // Add to list
                    treeLeafDict[dictKey].Add(info);
                }
                return true;
            }
            else return false;
        }

        public void BuildTree()
        {
            // Setup tree node root
            treeNodeRoot = new TreeNode<string>(componentTreeRoot.GetType().Name, null);
            // Setup dictionary
            treeLeafDict = new Dictionary<string, List<Tuple<string, string>>>();
            // Create tree
            CreateTreeNode(treeNodeRoot, componentTreeRoot);
        }

        public void RefreshTree()
        {
            BuildTree();
            DiscoveryComponentTreeNode();
        }
    }
}
