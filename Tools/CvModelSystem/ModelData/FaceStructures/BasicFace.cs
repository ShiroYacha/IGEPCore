using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public class BasicFace
    {
        [ComponentData(ComponentNature.Node)]
        protected List<int> indices;

        /// <summary>
        /// A list of vertices' indices of the face.
        /// </summary>
        public List<int> Indices
        {
            get
            {
                return indices;
            }
            set
            {
                indices = value;
            }
        }

        /// <summary>
        /// Number of vertices in this face.
        /// </summary>
        [ComponentData(ComponentNature.Leaf)]
        public int Count
        {
            get
            {
                return indices.Count;
            }
        }

        public override string ToString()
        {
            string faceString= "{Indice: ";
            for (int i = 0; i < indices.Count; i++)
                faceString += indices[i] + " ";
            faceString += "}";
            return faceString;
        }

    }
}
