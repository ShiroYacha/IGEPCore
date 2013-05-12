using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV;

namespace IgepCore.CV.ProcessSystem
{
    public interface ILayer:IDisplayable
    {
        string Name { get; }
        Dictionary<string, object> Proceed(Dictionary<string, object> argsDict);
    }
}
