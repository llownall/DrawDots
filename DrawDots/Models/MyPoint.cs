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

        public bool isPointed(MyPoint mouseClick, double radius)
        {
            return Math.Abs(Position.X - mouseClick.Position.X) <= radius && 
                Math.Abs(Position.Y - mouseClick.Position.Y) <= radius;
        }

        public double GetAngle() => 0;
    }
}
