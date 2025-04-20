using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class MakeC
    {
        public Arr Execute(Arr a, Arr b, int index)
        {
            var partB = new MinL().Execute(b.Data);
            var partA = new MinRTo().Execute(a.Data, index);
            return new Arr(partB.Length + partA.Length)
            {
                Data = partB.Concat(partA).ToArray()
            };
        }
    }
}
