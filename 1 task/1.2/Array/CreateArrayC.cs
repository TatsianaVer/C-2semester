using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant15
{
    public class CreateArrayC
    {
        public static Array Execute(Array a, Array b, int index)
        {
            var partB = GetAfterMin.Execute(b.Data);
            var partA = GetBetweenMinAndIndex.Execute(a.Data, index);

            return new Array(partB.Length + partA.Length)
            {
                Data = partB.Concat(partA).ToArray()
            };
        }
    }
}
