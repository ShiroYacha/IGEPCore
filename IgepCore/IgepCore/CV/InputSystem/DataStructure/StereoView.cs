using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    public class StereoView :  IView
    {
        private Image<Bgr, byte> leftImage;
        private Image<Bgr, byte> rightImage;
        private DateTime timeStamp;

        public StereoView(Image<Bgr, byte> leftImage, Image<Bgr, byte> rightImage)
        {
            this.leftImage = leftImage;
            this.rightImage = rightImage;
            this.timeStamp = DateTime.Now;
        }

        public Image<Bgr, byte> LeftImage
        {
            get { return leftImage; }
        }

        public Image<Bgr, byte> RightImage
        {
            get { return rightImage; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
        }

        public Image<Bgr, byte> GetPrimaryView(int width,int height)
        {
            return width == 0 && height == 0 ? leftImage : leftImage.Resize(width, height, Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
        }
    }
}
