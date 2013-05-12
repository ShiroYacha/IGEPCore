using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CvConsole
{
    public static class ModelDataExtractorFactory
    {
        public static IModelDataExtractor CreateTriangularExtractor()
        {
            return new TriangularExtractor();
        }
    }

    public static class ModelDataGeneratorFactory
    {
        public static IModelDataGenerator2D CreateViewPointDataGenerator(Viewport viewPort)
        {
            string xmlPath = FilePath.GetFilePath("Resources", "Factory.xml");
            ViewPointDataGenerator generator = XmlReflectionFactory<ViewPointDataGenerator>.CreateFromXml(xmlPath, "IModelDataGenerator2D");
            IViewPointProvider provider = XmlReflectionFactory<IViewPointProvider>.CreateFromXml(xmlPath, "IViewPointProvider");
            generator.ViewProvider = provider;
            generator.ViewPort = viewPort;
            return generator;
        }
    }
}
