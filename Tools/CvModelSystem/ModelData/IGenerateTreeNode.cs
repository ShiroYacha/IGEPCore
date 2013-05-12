using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public interface IGenerateTreeNode
    {
        /// <summary>
        /// Generate a presentative tree node.
        /// </summary>
        TreeNode GenerateTreeNode();
    }
}
