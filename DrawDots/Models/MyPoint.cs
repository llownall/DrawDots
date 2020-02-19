using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawDots.Models
{
    class MyPoint : IElement
    {
        public readonly Point Position;

        public MyPoint(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
        }


        public double GetAngle() => 0;
    }
}
