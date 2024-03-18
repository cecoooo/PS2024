using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkCourse1TU_ISN.AditionalElements;
using CourseWorkCourse1TU_ISN.BaseClass;

namespace CourseWorkCourse1TU_ISN.Shapes
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double l, double w) 
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            return Length*Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
