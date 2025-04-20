using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant15
{
    public class GetAfterMin
    {
        public static double[] Execute(double[] data)
        {
            int minIndex = Array.IndexOf(data, data.Min());
            return data.Skip(minIndex + 1).ToArray();
        }
    }
}
