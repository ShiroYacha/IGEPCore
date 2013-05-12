using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MIConvexHull;

namespace CvConsole
{
	public interface IViewPointProvider 
	{
        ViewPoint[] ProvideViews();
	}
	
	public class EquiSphericalViewPointProvider : IViewPointProvider
	{
	    public EquiSphericalViewPointProvider(double radius, int nbPoints)
	    {
	    }

        public ViewPoint[] ProvideViews()
        {
            throw new Exception("The method or operation is not implemented.");
        }
	}

    public class DynamicViewPointProvider : IViewPointProvider
    {
        public ViewPoint[] ProvideViews()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
	
}
