using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Dept2MonthAvg
    {
        public void Execute(List<Teacher> list)
        {
            Console.WriteLine("\n--- Dept Avg (First 2 Months) ---");

            var groups = list.GroupBy(t => t.Dept);
            foreach (var grp in groups)
            {
                var avg = grp.Select(t => t.First2Avg).Average();
                Console.WriteLine($"{grp.Key}: {avg:F2} hrs");
            }
        }
    }
}
