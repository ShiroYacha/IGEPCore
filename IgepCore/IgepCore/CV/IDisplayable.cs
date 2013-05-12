using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;

namespace IgepCore.CV
{
    public interface IDisplayable
    {
        IImage Display(int width,int height);
    }
}
