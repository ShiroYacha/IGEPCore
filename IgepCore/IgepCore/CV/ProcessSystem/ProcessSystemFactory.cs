using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgepCore.CV.ProcessSystem
{
    public static class ProcessSystemFactory
    {
        public static NativeLayerProcessSystem CreateNativeLayerProcessSystem()
        {
            return new NativeLayerProcessSystem();
        }
    }
}
