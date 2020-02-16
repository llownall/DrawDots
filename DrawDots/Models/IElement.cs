using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    interface IElement
    {
        Pair<double, double> GetPos();

        double GetAngle();
    }
}
