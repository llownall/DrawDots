using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    public class Group
    {
        public readonly List<IElement> elements;
        public int groupThickness { get; private set; } = 5;
        public Color groupColor { get; private set; } = Color.FromArgb(255, 255, 255);
        public string name { get; private set; }

        public Group(string name)
        {
            this.name = name;
            elements = new List<IElement>();
        }

        public Group(string name, List<IElement> elements)
        {
            this.name = name;
            this.elements = elements;
        }

        public void Add(IElement element)
        {
            elements.Add(element);
        }

        public void setGroupThickness(int thickness)
        {
            groupThickness = thickness;
        }

        public void setGroupColor(Color color)
        {
            groupColor = color;
        }

        public int getNumberOfGroup()
        {
            return int.Parse(name.Split()[1]);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
