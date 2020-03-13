using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace DrawDots.Models
{
    public class MyPoint
    {
        public readonly int x;
        public readonly int y;

        [JsonConstructor]
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool isPointed(MyPoint mouseClick, double radius)
        {
            return Math.Abs(x - mouseClick.x) <= radius &&
                Math.Abs(y - mouseClick.y) <= radius;
        }

        public double GetAngle() => 0;
    }
}
