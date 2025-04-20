using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Max2
    {
        public int[] Execute(double[] data)
        {
            return data
                .Select((val, i) => new { val, i })
                .OrderByDescending(x => x.val)
                .ThenByDescending(x => x.i)
                .Take(2)
                .Select(x => x.i)
                .ToArray();
        }
    }
}
