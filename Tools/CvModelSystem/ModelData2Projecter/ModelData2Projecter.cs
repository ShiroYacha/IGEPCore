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
    public interface IModelData2Projecter
    {
        ColorModelData2 Project(ColorModelData3 modelData3, BasicModelStage modelStage, Viewport viewport);
    }
}
