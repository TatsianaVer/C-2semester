using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace UniversityTeachers
{
    public static class UniversityDataProcessor
    {
        public static IEnumerable<Teacher> inputTeachers()
        {
            var teachers = new List<Teacher>();

            Console.WriteLine(AppConstants.EnterTeachers);
            while (true)
            {
                try
                {
                    Console.Write(AppConstants.EnterLastName);
                    var lastName = Console.ReadLine();
                    if (string.Equals(lastName, AppConstants.Exit, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    Console.Write(AppConstants.EnterDepartment);
                    var department = Console.ReadLine();
                    if (string.Equals(department, AppConstants.Exit, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }

                    Console.Write(AppConstants.EnterMonthlyWorkload);
                    var workloadInput = Console.ReadLine()?.Split(' ');

                    if (workloadInput?.Length != 10)
                    {
                        throw new FormatException(AppConstants.TenNumbers);
                    }

                    var workload = workloadInput.Select(int.Parse).ToArray();

                    teachers.Add(new Teacher(lastName, department, workload));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{AppConstants.Error} {ex.Message}. {AppConstants.TryAgain}");
                }
            }
            return teachers;
        }

        public static void PrintTeachersByDepartment(IEnumerable<Teacher> teachers)
        {
            var grouped = teachers.OrderBy(t => t.Department).ThenBy(t => t.LastName).GroupBy(t => t.Department);

            foreach (var departmentGroup in grouped)
            {
                Console.WriteLine($"\nDepartment: {departmentGroup.Key}");
                foreach (var teacher in departmentGroup)
                {
                    Console.WriteLine($"- {teacher.LastName}: {AppConstants.AnnualWorkload} {teacher.AnnualWorkload} {AppConstants.Hours}");
                }
            }
        }

        public static Dictionary<string, double> CalculateAverageFirstTwoMonths(IEnumerable<Teacher> teachers)
        {
            return teachers.GroupBy(t => t.Department).ToDictionary(g => g.Key, g => g.Average(t => (t[0] + t[1]) / 2.0));
        }

        public static IEnumerable<Teacher> FindTeachersAboveAverage(IEnumerable<Teacher> teachers, double universityAverage)
        {
            return teachers.Where(t => t.MonthlyWorkload.Any(h => h > universityAverage));
        }

        public static double CalculateUniversityAverage(IEnumerable<Teacher> teachers)
        {
            var totalHours = teachers.Sum(t => t.MonthlyWorkload.Sum());
            var totalMonths = teachers.Count() * 10;

            return totalMonths > 0 ? (double)totalHours / totalMonths : 0;
        }
    }
}
