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
    public interface IModelData2Generator
    {
        ColorModelData2 Generate(ColorModelData2 modelData2);
    }
}
