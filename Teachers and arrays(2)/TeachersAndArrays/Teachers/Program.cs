using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{
    class Program
    {
        static void Run()
        {
            try
            {
                var teachers = UniversityDataProcessor.inputTeachers().ToList();
                Console.WriteLine("\n", AppConstants.TeachersByDepartment);
                UniversityDataProcessor.PrintTeachersByDepartment(teachers);

                var departmentAverages = UniversityDataProcessor.CalculateAverageFirstTwoMonths(teachers);
                Console.WriteLine("\n", AppConstants.AverageWorkload);

                foreach (var (department, avg) in departmentAverages)
                {
                    Console.WriteLine($"{department}: " +
                        $"{avg: F1} " +
                        $"{AppConstants.Hours}");
                }

                var universityAverage = UniversityDataProcessor.CalculateUniversityAverage(teachers);
                Console.WriteLine($"\n {AppConstants.MonthlyAverage}" +
                    $"{universityAverage: F1}" +
                    $"{AppConstants.Hours}");

                var aboveAverageTeachers = UniversityDataProcessor.FindTeacherAboveAverage(teachers, universityAverage);
                Console.WriteLine("\n", AppConstants.TeachersAboveAverage);

                if (aboveAverageTeachers.Any())
                {
                    foreach (var teacher in aboveAverageTeachers)
                    {
                        Console.WriteLine($"{teacher.LastName}" +
                            $"({teacher.Department})");
                    }
                }
                else
                {
                    Console.WriteLine(AppConstants.NoTeachers);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{AppConstants.CriticalError}" +
                    $"{ex.Message}");
            }
        }
    }
}
