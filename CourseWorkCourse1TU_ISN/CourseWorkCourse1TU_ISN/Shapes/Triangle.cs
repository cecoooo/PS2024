using CourseWorkCourse1TU_ISN.AditionalElements;
using CourseWorkCourse1TU_ISN.BaseClass;

namespace CourseWorkCourse1TU_ISN.Shapes
{
    internal class Triangle : Shape
    {
        public TriangleSides Sides { get; set; }
        public Triangle(TriangleSides sides)
        {
            Sides = sides;
        }

        public override double Area()
        {
            double p = Sides.Sides.Sum() / 2;
            double a = Sides.Sides[0];
            double b = Sides.Sides[0];
            double c = Sides.Sides[0];
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter()
        {
            return Sides.Sides.Sum();
        }
    }
}
