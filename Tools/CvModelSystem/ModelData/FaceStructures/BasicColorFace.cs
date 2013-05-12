using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    public class BasicColorFace : BasicFace, IColor
    {
        [ComponentData(ComponentNature.Leaf)]
        private Bgr bgr;
        [ComponentData(ComponentNature.Leaf)]
        private Hsv hsv;
        [ComponentData(ComponentNature.Leaf)]
        private System.Drawing.Color color;
    
        public Bgr Bgr
        {
            get
            {
                return bgr;
            }
            set
            {
                bgr = value;
                // Set color
                color = ConvertBgrToColor(bgr);
                // Set hsv
                hsv = ConvertColorToHsv(color);
            }
        }

        public bool CheckHue(float hueCenter, float range)
        {
            return hsv.Hue <= hueCenter + range && hsv.Hue >= hueCenter - range;
        }

        private System.Drawing.Color ConvertBgrToColor(Bgr bgr)
        {
            return System.Drawing.Color.FromArgb((int)bgr.Red, (int)bgr.Green, (int)bgr.Blue);
        }

        private Hsv ConvertColorToHsv(System.Drawing.Color color)
        {
            return new Hsv(color.GetHue(),color.GetSaturation(),color.GetBrightness());
        }


        public System.Drawing.Color GetColor()
        {
            return color;
        }

        public Hsv GetHsv()
        {
            return hsv;
        }
    }
}
