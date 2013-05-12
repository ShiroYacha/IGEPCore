using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

using CvModelSystem.Structure;

namespace CvModelSystem
{
    public class DirectProjecter : IModelData2Projecter
    {
        public ColorModelData2 Project(ColorModelData3 modelData3, BasicModelStage modelStage, Viewport viewport)
        {
            return DirectProject(modelData3, viewport, modelStage.StageStatus.Projection, modelStage.StageStatus.View, modelStage.StageStatus.World);
        }

        /// <summary>
        /// Project to 2D-unicolor-faces-initStageEffect using WVP matrices and a viewport.
        /// </summary>
        /// <param name="viewport">The 3D to 2D viewport.</param>
        /// <param name="projection">The projection matrix.</param>
        /// <param name="view">The view matrix.</param>
        /// <param name="world">The world matrix.</param>
        
        private ColorModelData2 DirectProject(ColorModelData3 modelData3,Viewport viewport, Matrix projection, Matrix view, Matrix world)
        {
            ColorModelData2 projModelData = new ColorModelData2();
            // Project all vertices
            List<Vector2> projVertices = new List<Vector2>();
            foreach (Vector3 vertex in modelData3.Vertices)
            {
                Vector3 projVertex = viewport.Project(vertex, projection, view, world);
                projVertices.Add(new Vector2(projVertex.X, projVertex.Y));
            }
            projModelData.Vertices = projVertices;
            // Copy all faces
            BasicColorFace[] copiedModelFaces = new BasicColorFace[modelData3.Faces.Count];
            modelData3.Faces.CopyTo(copiedModelFaces);
            projModelData.Faces = copiedModelFaces.ToList();
      
            return projModelData;
        }
    }
}
