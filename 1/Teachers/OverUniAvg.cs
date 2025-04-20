using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class OverUniAvg
    {
        public void Execute(List<Teacher> list)
        {
            Console.WriteLine("\n--- Teachers with Month > Univ Avg ---");

            double uniAvg = list.SelectMany(t => Enumerable.Range(0, 10).Select(i => t[i])).Average();

            var over = list.Where(t => t.HasAbove(uniAvg)).ToList();

            if (over.Count == 0)
            {
                Console.WriteLine("No such teachers.");
            }
            else
            {
                foreach (var t in over)
                {
                    Console.WriteLine($"{t.Name} ({t.Dept})");
                }
            }
        }
    }
}
