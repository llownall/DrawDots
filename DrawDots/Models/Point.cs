using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    class Point : IElement
    {
        Pair<double, double> position;

        public Point(double x, double y)
        {
            position.First = x;
            position.Second = y;
        }

        public double GetAngle() => 0;

        public Pair<double, double> GetPos() => position;
    }
}
