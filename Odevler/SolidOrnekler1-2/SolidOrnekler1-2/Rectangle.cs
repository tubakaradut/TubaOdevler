using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOrnekler1_2
{
 public   class Rectangle:Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public Rectangle(double width,double height)
        {
            Width = width;
            Height = height;
        }
    }
}
