using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;
using MIConvexHull;

using CvModelSystem.Structure;

namespace CvModelSystem
{
    public interface IModelData3Extractor
    {
         ColorModelData3 ExtractModelData(BasicModelStage modelStage);
    }

    public class TriangularExtractor : IModelData3Extractor
    {
        public ColorModelData3 ExtractModelData(BasicModelStage modelStage)
        {
            // Extract initStageEffect data 
            List<Vector3> vertices = new List<Vector3>();
            List<VertexHelper.TriangleVertexIndices> indices = new List<VertexHelper.TriangleVertexIndices>();
            List<Bgr> bgrs = new List<Bgr>();
            VertexHelper.ExtractTrianglesFrom(modelStage.StageModel, vertices, indices, Matrix.Identity, bgrs);
            // Return converted data
            return ConvertToModelData(vertices, indices, bgrs);
        }

        private ColorModelData3 ConvertToModelData(List<Vector3> vertices, List<VertexHelper.TriangleVertexIndices> indices,List<Bgr> bgrs)
        {
            ColorModelData3 modelData = new ColorModelData3();
            // Convert vertices
            modelData.Vertices = vertices;
            // Convert faces
            List<BasicColorFace> faces = new List<BasicColorFace>();
            for (int i = 0; i < indices.Count; i++)
            {
                // Set face indices
                List<int> faceIndices = new List<int>
                { 
                     indices[i].A,
                     indices[i].B,
                     indices[i].C
                };
                // Set face bgr
                Bgr faceBgr = bgrs[i];
                // Add to face list
                faces.Add(new BasicColorFace() { Indices = faceIndices, Bgr = faceBgr });
            }
            modelData.Faces = faces;
            return modelData;
        }
    }
}
