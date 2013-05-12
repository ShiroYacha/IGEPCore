using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;
using MIConvexHull;

using CvModelSystem.Structure;

namespace CvModelSystem
{
    public class ConvexHull2Generator:IModelData2Generator
    {
        public ColorModelData2 Generate(ColorModelData2 modelData2)
        {
            return CreateConvexHull2(modelData2);
        }

        /// <summary>
        /// Create a unicolor 2D convex hull from a 2D-unicolor-faces-initStageEffect  
        /// </summary>
        /// <param name="xmlPath">Xml file path to load.</param>
        /// <remarks>The color of the convex hull is the dominant color of the 2D initStageEffect (so far not implement,take first color instead, works only on unicolor initStageEffect data)</remarks>
        private ColorConvexHull2 CreateConvexHull2(ColorModelData2 rawColorModelData2)
        {
            // Use the intermediate class to create convex hull
            List<Vertex2> vertices = new List<Vertex2>();
            vertices.AddRange(rawColorModelData2.Vertices.ConvertAll<Vertex2>((vector2) => { return new Vertex2(vector2); }));
            ConvexHull<Vertex2, DefaultConvexFace<Vertex2>> convexHull = ConvexHull.Create<Vertex2>(vertices);
            // Adapte to ColorModelData2
            ColorConvexHull2 adaptedConvexHull = new ColorConvexHull2();
            // Adapte vertices
            List<Vector2> adaptedVertices = new List<Vector2>();
            DefaultConvexFace<Vertex2> nextFace = convexHull.Faces.First().Adjacency[0];
            adaptedVertices.Add(new Vector2((float)convexHull.Faces.First().Vertices[0].Position[0], (float)convexHull.Faces.First().Vertices[0].Position[1]));
            while (nextFace != convexHull.Faces.First())
            {
                adaptedVertices.Add(nextFace.Vertices[0].ToVector2());
                nextFace = nextFace.Adjacency[0];
            }
            adaptedConvexHull.Vertices = adaptedVertices;
            // Adapte faces (only one face with adjacent vertices)
            List<int> adaptedIndices = new List<int>();
            for (int i = 0; i < adaptedConvexHull.Vertices.Count; i++)
                adaptedIndices.Add(i);
            adaptedConvexHull.Faces = new List<BasicColorFace>
            {
                new BasicColorFace()
                {
                    Bgr=rawColorModelData2.Faces[0].Bgr,
                    Indices=adaptedIndices
                }
            };
            return adaptedConvexHull;
        }
    }
}
