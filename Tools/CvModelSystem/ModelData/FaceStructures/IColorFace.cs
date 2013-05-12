using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public interface IColor
    {
        /// <summary>
        /// Get or set the hsv color of the face.
        /// </summary>
        /// <remarks>Setting this property configures other color properties.</remarks>
        Bgr Bgr
        {
            get;
            set;
        }

        /// <summary>
        /// Check if the face's hue is in range
        /// </summary>
        /// <param name="hueCenter">The center value of the hue range.</param>
        /// <param name="range">The range.</param>
        bool CheckHue(float hueCenter, float range);

        /// <summary>
        /// Get the System.Drawing.Color of the face.
        /// </summary>
        System.Drawing.Color GetColor();

        /// <summary>
        /// Get the Hsv of the face.
        /// </summary>
        Hsv GetHsv();
    }
}
