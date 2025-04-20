using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class MinL
    {
        public double[] Execute(double[] data)
        {
            int idx = Array.IndexOf(data, data.Min());
            return data.Skip(idx + 1).ToArray();
        }
    }
}
