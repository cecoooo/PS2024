using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCourse1TU_ISN.AditionalElements
{
    internal class TriangleSides
    {
        public double[] Sides { get; private set; }

        public TriangleSides(double a, double b, double c) 
        {
            CheckSides(a, b, c);
            Sides = new double[3];
            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;
        }

        private void CheckSides(double a, double b, double c) 
        {
            bool res = true;
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("No triangle exists with those sides.");
        }
    }
}
