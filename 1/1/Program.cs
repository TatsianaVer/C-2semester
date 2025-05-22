using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityTeachers;
using Variant11;

namespace Menu
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(AppConstants.Menu);
                Console.WriteLine(AppConstants.RunArray);
                Console.WriteLine(AppConstants.RunTeachers);
                Console.WriteLine(AppConstants.Exit);
                Console.WriteLine(AppConstants.Option);

                switch (Console.ReadLine())
                {
                    case "1":
                        RunArrayProcessing();
                        break;
                    case "2":
                        RunUniversityTeachers();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(AppConstants.InvalidOption);
                        Errors.HoldScreen();
                        break;
                }
            }
        }

        private static void RunArrayProcessing()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(AppConstants.RunArrayProcess);

                var arrayA = new ArrayManager();
                Console.WriteLine(AppConstants.InputA);
                arrayA.ReadFromInput();

                var arrayB = new ArrayManager();
                Console.WriteLine(AppConstants.InputB);
                arrayB.ReadFromInput();

                int[] arrayC = ArrayProcessor.GenerateArrayC(arrayA, arrayB);
                Console.WriteLine($"{AppConstants.GeneratedC} {string.Join(" ", arrayC)}");
            }
            catch (Exception ex)
            {
                Errors.ShowError(ex.Message);
            }
            Errors.HoldScreen();
        }

        private static void RunUniversityTeachers()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(AppConstants.RunUniversityTeachers);

                var teachers = UniversityDataProcessor.inputTeachers().ToList();
                UniversityDataProcessor.PrintTeachersByDepartment(teachers);

                var departmentAverages = UniversityDataProcessor.CalculateAverageFirstTwoMonths(teachers);
                Console.WriteLine("\n", AppConstants.TwoMonthsAverageWorkload);

                foreach (var (department, avg) in departmentAverages)
                {
                    Console.WriteLine($"{department}: {avg: F1} {AppConstants.Hours}");
                }

                var universityAverage = UniversityDataProcessor.CalculateUniversityAverage(teachers);
                Console.WriteLine($"\n {AppConstants.MonthlyAverage} {universityAverage:F1} {AppConstants.Hours}");

                var aboveAverageTeachers = UniversityDataProcessor.FindTeachersAboveAverage(teachers, universityAverage);
                Console.WriteLine($"\n {AppConstants.TeachersAboveAverage}");
                if (aboveAverageTeachers.Any())
                {
                    foreach (var teacher in aboveAverageTeachers)
                    {
                        Console.WriteLine($"{teacher.LastName} ({teacher.Department})");
                    }
                }
                else
                {
                    Console.WriteLine(AppConstants.NoTeachers);
                }
            }
            catch (Exception ex)
            {
                Errors.ShowError(ex.Message);
            }
            Errors.HoldScreen();
        }
    }
}