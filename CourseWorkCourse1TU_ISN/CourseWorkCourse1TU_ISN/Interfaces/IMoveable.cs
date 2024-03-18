using CourseWorkCourse1TU_ISN.AditionalElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCourse1TU_ISN.Interfaces
{
    internal interface IMoveable
    {
        public abstract void Move(Coords newCoords);
    }
}
