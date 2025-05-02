using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace Variant11
{
    public static class ArrayProcessor
    {
        public static int[] GenerateArrayC(ArrayManager sourceA, ArrayManager sourceB)
        {
            if (sourceA.Data.Length == 0 || sourceB.Data.Length == 0)
            {
                throw new ArgumentException(AppConstants.EmptyArrayError);
            }

            int firstMinBIndex = sourceB.FindFirstMinIndex();
            var segmentB = sourceB.Data.Skip(firstMinBIndex + 1).ToArray();

            int lastMinIndex = sourceA.FindLastMinIndex();

            if (AppConstants.ElementIndex < 0 || AppConstants.ElementIndex >= sourceA.Data.Length)
            {
                throw new IndexOutOfRangeException(AppConstants.IndexOutOfRangeMessage);
            }

            var segmentA = sourceA.Data.Skip(lastMinIndex + 1).Take(AppConstants.ElementIndex - lastMinIndex).ToArray();

            return segmentB.Concat(segmentA).ToArray();
        }
    }
}
