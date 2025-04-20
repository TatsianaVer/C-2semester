using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        public static void Main2()
        {
            try
            {
                var list = new Fill().Execute();

                new PrintAll().Execute(list);
                new Dept2MonthAvg().Execute(list);
                new OverUniAvg().Execute(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
