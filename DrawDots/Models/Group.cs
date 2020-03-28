using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{

    public struct GroupTransformation
    {
        public int xTransition { get; set; }
        public int yTransition { get; set; }

        public GroupTransformation(int x, int y)
        {
            xTransition = x;
            yTransition = y;
        }
    }

    public class Group
    {
        public readonly List<MyPoint> elements;
        public int groupThickness { get; private set; } = 5;
        public Color groupColor { get; private set; } = Color.FromArgb(0, 255, 0);
        public string name { get; private set; }
        public GroupTransformation transformation { get; private set; } = new GroupTransformation(0, 0);

        public Group(string name)
        {
            this.name = name;
            elements = new List<MyPoint>();
        }

        public Group(string name, List<MyPoint> elements)
        {
            this.name = name;
            this.elements = elements;
        }

        [JsonConstructor]
        public Group(string name, List<MyPoint> elements, int groupThickness)
        {
            this.name = name;
            this.elements = elements;
            this.groupThickness = groupThickness;
        }

        public void Add(MyPoint element)
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

        public void move(int x = 0, int y = 0)
        {
            var tempTransform = transformation;
            tempTransform.xTransition += x;
            tempTransform.yTransition += y;
            transformation = tempTransform;
        }
    }
}
