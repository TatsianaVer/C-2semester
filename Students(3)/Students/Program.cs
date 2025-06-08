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
    public static void Main()
    {
        UndergraduateStudent undergraduate = new UndergraduateStudent("Mila");
        undergraduate.AddCourse("Mathematics", 3, 4.0);
        double undergraduateGPA = undergraduate.CalculateGpa();
        Console.WriteLine($"Undergraduate GPA: {undergraduateGPA:F2}");

        PhdStudent phd = new PhdStudent("Bob");
        phd.AddCourse("Research Project", 6, 4.0);
        phd.AddCourse("Seminar", 2, 3.8);
        double phdGpa = phd.CalculateGpa();
        Console.WriteLine($"PhD GPA: {phdGpa:F2}");
    }
}

