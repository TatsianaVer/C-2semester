using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class NegProd
    {
        public double Execute(Arr arr)
        {
            var data = arr.Data;
            if (data.Length < 2) throw new ArgumentException("Too short");

            var idxs = new Max2().Execute(data);
            int start = idxs.Max() + 1;

            return data
                .Skip(start)
                .Where(x => x < 0)
                .DefaultIfEmpty(1)
                .Aggregate((a, b) => a * b);
        }
    }
}
