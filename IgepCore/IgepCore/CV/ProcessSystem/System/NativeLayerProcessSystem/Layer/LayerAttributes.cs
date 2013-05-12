using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgepCore.CV.ProcessSystem
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LayerBuilderAttribute : Attribute
    {
        
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class LayerAttribute : Attribute
    {
        private int sequence;

        public int Sequence { get { return sequence; } }

        public LayerAttribute(int sequence)
        {
            this.sequence = sequence;
        }
    }
}
