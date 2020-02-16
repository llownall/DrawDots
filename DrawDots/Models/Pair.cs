﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    public class Pair<T, K>
    {
        public T First { get; set; }

        public K Second { get; set; }
    }
}
