using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOrnekler1_2
{
 public  class Circle:Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI; 
        }
    }
}
