using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkCourse1TU_ISN.BaseClass;

namespace CourseWorkCourse1TU_ISN.Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }         
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Area()
        {
            return Radius*Radius*Math.PI;
        }

        public override double Perimeter()
        {
            return 2*Radius*Math.PI;    
        }
    }
}
