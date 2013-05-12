using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IgepCore.CV.InputSystem
{
    public class SingleView :  IView
    {
        private Image<Bgr, byte> image;
        private DateTime timeStamp;

        public SingleView(Image<Bgr, byte> image)
        {
            this.image = image;
            this.timeStamp = DateTime.Now;
        }

        public Image<Bgr, byte> Image
        {
            get { return image; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
        }

        public Image<Bgr, byte> GetPrimaryView(int width=0,int height=0)
        {
            return width==0&&height==0?image:image.Resize(width,height,Emgu.CV.CvEnum.INTER.CV_INTER_AREA);
        }
    }

}
