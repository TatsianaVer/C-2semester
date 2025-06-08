using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayAnalyzer
    {
        public static int CountSpecialValues(int[] data)
        {
            if (data.Length < 3)
            {
                return 0;
            }

            int maxIndex = Array.IndexOf(data, data.Max());
            int minIndex = Array.IndexOf(data, data.Min());

            if (Math.Abs(maxIndex - minIndex) <= 1)
            {
                return 0;
            }

            int start = Math.Min(maxIndex, minIndex) + 1;
            int end = Math.Max(minIndex, maxIndex) - 1;

            int sumBetween = data.Skip(start)
                .Take(end - start)
                .Sum();

            return data.Count(value => value == sumBetween);

        }
    }
}
