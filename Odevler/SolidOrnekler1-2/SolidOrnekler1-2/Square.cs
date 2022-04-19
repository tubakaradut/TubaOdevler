using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOrnekler1_2
{
    public class Square : Shape
    {
        public Square(double edge)
        {
            Edge = edge;
        }
        public double  Edge { get; set; }
        public override double Area()
        {
            return Edge * Edge;
        }
    }
}
