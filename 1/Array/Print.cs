using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Print
    {
        public void Execute(Arr arr)
        {
            Console.WriteLine($"Array: {string.Join(", ", arr.Data)}");
        }
    }
}
