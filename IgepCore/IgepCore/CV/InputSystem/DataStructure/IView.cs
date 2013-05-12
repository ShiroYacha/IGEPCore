using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    public interface IView
    {
        DateTime TimeStamp { get; }
        Image<Bgr, byte> GetPrimaryView(int width=0,int height=0);
    }
}
