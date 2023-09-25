using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public static class GeometryCalc
    {
        public static double CalculateArea<T>(T shape) where T : IFigure
        {
            return shape.CalculateArea();
        }
    }
}
