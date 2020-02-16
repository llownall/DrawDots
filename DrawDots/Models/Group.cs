using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    class Group
    {
        private List<IElement> elements;

        public Group() => elements = new List<IElement>();

        public Group(List<IElement> elements) => this.elements = elements;

        internal List<IElement> Elements { get => elements; set => elements = value; }
    }
}
