using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entry point of the application.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method to demonstrate GPA calculation for different types of students.
    /// </summary>
    public static void Main()
    {
        UndergraduateStudent undergraduated = new UndergraduateStudent("Mila");
        undergraduated.AddCourse("Mathematics", 3, 4.0);
        double undergraduatedGPA = undergraduated.CalculateGpa();
        Console.WriteLine($"Undergraduate GPA: {undergraduatedGPA:F2}");


        
        PhdStudent phd = new PhdStudent("Bob");
        phd.AddCourse("Research Project", 6, 4.0);
        phd.AddCourse("Seminar", 2, 3.8);
        double phdGpa = phd.CalculateGpa();
        Console.WriteLine($"PhD GPA: {phdGpa:F2}");
    }
}
