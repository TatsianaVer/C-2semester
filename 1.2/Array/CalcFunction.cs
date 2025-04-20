using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant15
{
    public class CalcFunction
    {
        public static double Execute(double a, double b, double c)
        {
            return (2 * Math.Sin(a) + 3 * b * Math.Pow(Math.Cos(c), 3)) / (a + b);
        }
    }
}
