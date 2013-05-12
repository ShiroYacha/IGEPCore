using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace CvConsole
{
	public interface IModelDataGenerator2D
	{
        ModelDataBuffer2D GenerateData(Model model);
	}

    public abstract class ViewPointDataGenerator : IModelDataGenerator2D
    {
        protected IModelDataExtractor dataExtractor;
        protected IViewPointProvider viewProvider;

        private Viewport viewPort;

        public Viewport ViewPort
        {
            get { return viewPort; }
            set { viewPort = value; }
        }

        public IViewPointProvider ViewProvider
        {
            get { return ViewProvider; }
            set { viewProvider = value; }
        }

        public ModelData2D ProjectDataFromView(Model model,ModelData3D modelData3D,ViewPoint viewPoint)
        {
            ModelData2D modelData2D = new ModelData2D();
            Vector2[] projVertices = new Vector2[modelData3D.Vertices.Length];
            int[][] projIndice = new int[modelData3D.Indices.Length][];
            for (int i = 0; i < projVertices.Length;i++ )
            {
                // Project vertices
                Vector3 projVertex = viewPort.Project(modelData3D.Vertices[i], viewPoint.Projection, viewPoint.View, viewPoint.World);
                projVertices[i] = new Vector2(projVertex.X,projVertex.Y);
                // Project indices (same => copy)
                projIndice[i] = new int[modelData2D.Indices[i].Length];
                for (int j = 0; j < projIndice.Length; j++)
                {
                    projIndice[i][j] = modelData3D.Indices[i][j];
                }
            }
            // Setup projection data
            modelData2D.Vertices = projVertices;
            modelData2D.Indices = projIndice;
            // Return data
            return modelData2D;
        }

        public ModelDataBuffer2D GenerateData(Model model)
        {
            // Initialize initStageEffect data buffer
            ModelDataBuffer2D modelData = new ModelDataBuffer2D();
            // Generate views
            ViewPoint[] views = viewProvider.ProvideViews();
            foreach (ViewPoint view in views)
            {
                ModelData3D modelData3D = dataExtractor.ExtractModelData(model);
                ModelData2D modelData2D = ProjectDataFromView(model,modelData3D, view);
                modelData.PushData(GenerateData(modelData2D));
            }
            return modelData;
        }

        public abstract ModelData2D GenerateData(ModelData2D modelData2D);
    }

    public class ConvexHullGenerator : ViewPointDataGenerator
    {
        public ConvexHullGenerator()
        {
        }
        public override ModelData2D GenerateData(ModelData2D modelData2D)
        {

            return new ModelData2D();
        }

    }

    public class DirectProjectionGenerator : ViewPointDataGenerator
    {
        public DirectProjectionGenerator()
        {
        }
        public override ModelData2D GenerateData(ModelData2D modelData2D)
        {
            return new ModelData2D();
        }
    }
}