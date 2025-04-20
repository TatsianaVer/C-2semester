using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class PrintAll
    {
        public void Execute(List<Teacher> list)
        {
            Console.WriteLine("\n--- All Teachers by Department ---");
            foreach (var t in list.OrderBy(x => x.Dept))
            {
                Console.WriteLine($"{t.Name} ({t.Dept}) - Year Load: {t.YearLoad}");
            }
        }
    }
}
