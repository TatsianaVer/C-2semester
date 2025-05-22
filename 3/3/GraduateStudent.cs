using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a graduate student, inheriting from Student.
/// </summary>
public class GraduateStudent : Student
{
    /// <summary>
    /// Minimum grade required for a course to be counted in GPA calculation.
    /// </summary>
    private const double MinimumGrade = 3.0;

    /// <summary>
    /// Initializes a new instance of GraduateStudent with the specified name.
    /// </summary>
    /// <param name="name">Name of the graduate student.</param>
    public GraduateStudent(string name) : base(name) { }

    /// <summary>
    /// Calculates the GPA of the graduate student.
    /// Courses with grade below MinimumGrade are excluded from calculation.
    /// </summary>
    /// <returns>The calculated GPA as a double.</returns>
    public override double CalculateGpa()
    {
        double totalGradePoints = 0.0;
        double totalCredits = 0.0;

        foreach (var course in Courses)
        {
            if (course.Grade < MinimumGrade)
            {
                continue;
            }

            totalGradePoints += course.Grade * course.Credit;
            totalCredits += course.Credit;
        }

        if (totalCredits == 0)
        {
            return 0;
        }

        return totalGradePoints / totalCredits;
    }
}