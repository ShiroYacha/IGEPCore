using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    /// <summary>
    /// 3D initStageEffect data with unicolor faces.
    /// </summary>
    public class ColorModelData3 : ModelData
    {
        [ComponentData(ComponentNature.Node)]
        protected List<BasicColorFace> faces;
        [ComponentData(ComponentNature.Node)]
        protected List<Vector3> vertices;
        [ComponentData(ComponentNature.Leaf)]
        public override int Dimension
        {
            get
            {
               return 3;
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
        /// A list of 3D vertices.
        /// </summary>
        public List<Vector3> Vertices
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

    }
}
