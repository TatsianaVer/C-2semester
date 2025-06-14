﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace Arrays
{
    public static class MathCalculator
    {
        public static double CalculateFunction(int a, int b, int c)
        {
            if (a + b == 0)
            {
                throw new DivideByZeroException(AppConstants.DivisionByZeroMessage);
            }

            return (2 * Math.Sin(a) + 3 * b * Math.Pow(Math.Cos(c), 3)) / (a + b);
        }
    }
}
