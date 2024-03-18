using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWorkCourse1TU_ISN.AditionalElements;
using CourseWorkCourse1TU_ISN.Interfaces;

namespace CourseWorkCourse1TU_ISN.BaseClass
{
    abstract class Shape : IDrawable, IMoveable
    {
        public Coords Coordinates;
        public double SquareArea;
        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Draw()
        {
            Console.WriteLine("Draw sth...");
        }

        public virtual void Move(Coords newCoords)
        {
            Coordinates = newCoords;
        }
    }
}
