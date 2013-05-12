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
    /// <summary>
    /// 2D initStageEffect data with unicolor faces.
    /// </summary>
    public class ColorModelData2 : ModelData
    {
        [ComponentData(ComponentNature.Node)]
        protected List<BasicColorFace> faces;
        [ComponentData(ComponentNature.Node)]
        protected List<Vector2> vertices;
        [ComponentData(ComponentNature.Leaf)]
        public override int Dimension
        {
            get
            {
                return 2;
            }
        }

        /// <summary>
        /// A list of faces.
        /// </summary>
        public List<BasicColorFace> Faces
        {
            get
            {
                return faces;
            }
            set
            {
                faces = value;
            }
        }

        /// <summary>
        /// A list of 2D vertices.
        /// </summary>
        public List<Vector2> Vertices
        {
            get
            {
                return vertices;
            }
            set
            {
                vertices = value;
            }
        }

        /// <summary>
        /// Draw the initStageEffect data with a paint event argument.
        /// </summary>
        /// <param name="e">The paint event argument.</param>
        /// <param name="showVertices">Show vertices on picture box or not.</param>
        /// <param name="fillFaceColor">Fill the faces with their color or not.</param>
        public virtual void Draw(PaintEventArgs e, bool showVertices, bool fillFaceColor)
        {
            // Default drawing settings
            Brush defaultFontBrush = Brushes.Black;
            Pen defaultPen = new Pen(defaultFontBrush);
            const float defaultRadias = 5;
            // Clear graphic canvas
            e.Graphics.Clear(System.Drawing.Color.White);
            // Draw edges and faces
            foreach (BasicColorFace face in faces)
            {
                // Get triangle points
                PointF[] pts = new PointF[face.Count];
                for (int i = 0; i < pts.Length; i++)
                {
                    Vector2 vertex = vertices[face.Indices[i]];
                    pts[i] = new PointF(vertex.X, vertex.Y);
                }
                // Fill faces with their color if requested
                if (fillFaceColor)
                {
                    e.Graphics.FillPolygon(new SolidBrush(face.GetColor()), pts);
                }
                // Draw edges
                e.Graphics.DrawLines(defaultPen,pts);
            }
            // Draw vertices
            int count = 0;
            foreach (Vector2 vertex in vertices)
            {
                // Get point
                PointF center = new PointF(vertex.X, vertex.Y);
                // Draw point
                e.Graphics.DrawEllipse(defaultPen, new System.Drawing.RectangleF(center.X - defaultRadias / 2.0f, center.Y - defaultRadias / 2.0f, defaultRadias, defaultRadias));
                // Draw coordinate strings if requested
                if (showVertices)
                    e.Graphics.DrawString(
                        "(" + Math.Round(Convert.ToDecimal(center.X), 2) + ","
                        + Math.Round(Convert.ToDecimal(center.Y), 2) + ") ["+ (count++) + "]",
                        new Font(FontFamily.GenericSansSerif, 6.5f),
                        defaultFontBrush,
                        center
                        );
            }
        }

    }

    public static class Vector2Extension
    {
        public static PointF ToPointF(this Vector2 vector2)
        {
            return new PointF(vector2.X, vector2.Y);
        }
    }
}
