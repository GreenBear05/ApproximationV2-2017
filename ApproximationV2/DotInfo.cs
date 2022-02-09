using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationV2
{
    public class DotInfo
    {
        public float X { get; set; }
        public float Y { get; set; }

        public DotInfo Self { get { return this; } }

        public DotInfo(float x,float y)
        {
            X = x;
            Y = y;

        }
        public DotInfo(DotInfo dotInfo)
        {
            X = dotInfo.X;
            Y = dotInfo.Y;
           
        }
    } 
}
