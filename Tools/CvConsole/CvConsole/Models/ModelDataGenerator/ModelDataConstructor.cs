using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CvConsole
{
	public class ModelDataConstructor 
	{
		private IModelDataGenerator2D dataGenerator;
        private IModelDataExtractor dataExtractor;
	
	    public ModelDataConstructor(Viewport viewport)
	    {
            // Setup data generator
            dataGenerator = ModelDataGeneratorFactory.CreateViewPointDataGenerator(viewport);
            // Setup data extractor
            dataExtractor = ModelDataExtractorFactory.CreateTriangularExtractor();
	    }

        public ModelDataBuffer2D Construct(Model model)
		{
	        return dataGenerator.GenerateData(model);
		}
	}
}
