using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV.Structure;

namespace CvConsole
{
    public interface IModelDataExtractor
    {
        ModelData3D ExtractModelData(Model model);
    }

    public class TriangularExtractor : IModelDataExtractor
    {
        public ModelData3D ExtractModelData(Model model)
        {
            // Extract initStageEffect data 
            List<Vector3> vertices = new List<Vector3>();
            List<VertexHelper.TriangleVertexIndices> indices = new List<VertexHelper.TriangleVertexIndices>();
            List<Bgr> bgrs = new List<Bgr>();
            VertexHelper.ExtractTrianglesFrom(model, vertices, indices, Matrix.Identity, bgrs);
            // Return converted data
            return ConvertToModelData(vertices,indices);
        }

        private ModelData3D ConvertToModelData(List<Vector3> vertices, List<VertexHelper.TriangleVertexIndices> indices)
        {
            ModelData3D modelData = new ModelData3D();
            // Convert vertices
            modelData.Vertices = vertices.ToArray();
            // Convert indices
            int[][] convIndice=new int[indices.Count][];
            for (int i = 0; i < convIndice.Length;i++ )
            {
                convIndice[i] = new int[3];
                convIndice[i][0] = indices[i].A;
                convIndice[i][0] = indices[i].B;
                convIndice[i][0] = indices[i].C;
            }
            modelData.Indices = convIndice;
            return modelData;
        }
    }
}
