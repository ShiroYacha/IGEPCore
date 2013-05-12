using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;


namespace CvConsole
{
    public class ModelDataBuffer2D
	{
        private List<ModelData2D> modelDataCollection;

        public void PushData(ModelData2D modelData)
	    {
	        modelDataCollection.Add(modelData);
	    }
	
	    public void GenerateXmlFile(string filePath)
	    {
	
	    }
	}
	
	public class ModelData3D
	{
	    public Vector3[] Vertices { get; set; }
	    public int[][] Indices { get; set; }
	}

    public class ModelData2D
    {
        public Vector2[] Vertices { get; set; }
        public int[][] Indices { get; set; }
    }
}

