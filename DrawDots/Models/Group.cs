using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawDots.Models
{
    public class Group
    {
        public readonly List<MyPoint> elements;
        public int groupThickness { get; private set; } = 5;
        public string name { get; private set; }

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
