using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    public class Group
    {
        public readonly List<IElement> elements;
        public int groupThickness { get; private set; } = 1;

        public Group() => elements = new List<IElement>();

        public Group(List<IElement> elements) => this.elements = elements;

        public void Add(IElement element)
        {
            elements.Add(element);
        }

        public void setGroupThickness(int thickness)
        {
            groupThickness = thickness;
        }
    }
}
