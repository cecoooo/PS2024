using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkCourse1TU_ISN.BaseClass;

namespace CourseWorkCourse1TU_ISN.Shapes
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square(double s)
        {
            Side = s;
        }

        public override double Area()
        {
            return Side*Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}
