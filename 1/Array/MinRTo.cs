using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class MinRTo
    {
        public double[] Execute(double[] data, int index)
        {
            int idx = Array.LastIndexOf(data, data.Min());
            if (index < idx) throw new ArgumentException("Index must be >= right min");
            return data.Skip(idx).Take(index - idx + 1).ToArray();
        }
    }
}
