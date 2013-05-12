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
    [XmlType("ColorConvexHull2")]
    public sealed class ColorConvexHull2 : ColorModelData2
    {
        public override void Draw(PaintEventArgs e, bool showVertices, bool fillFaceColor)
        {
            base.Draw(e, showVertices, fillFaceColor);
            // Close the convex hull loop
            Brush defaultFontBrush = Brushes.Black;
            Pen defaultPen = new Pen(defaultFontBrush);
            e.Graphics.DrawLine(defaultPen, vertices.Last().ToPointF(), vertices.First().ToPointF());
        }
    }
}
