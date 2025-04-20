using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Fill
    {
        public List<Teacher> Execute()
        {
            Console.Write("Enter number of teachers: ");
            int count = int.Parse(Console.ReadLine());
            var list = new List<Teacher>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nTeacher #{i + 1}");
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Department: ");
                var dept = Console.ReadLine();
                Console.Write("Monthly load (10 values, space-separated): ");
                var raw = Console.ReadLine().Split(' ');
                if (raw.Length != 10) throw new FormatException("Need exactly 10 values");

                var load = raw.Select(double.Parse).ToArray();
                list.Add(new Teacher(name, dept, load));
            }

            return list;
        }
    }

}
