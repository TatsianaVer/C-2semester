using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an undergraduate student.
/// </summary>
public class UndergraduateStudent : Student
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UndergraduateStudent"/> class.
    /// </summary>
    /// <param name="name">Name of the student.</param>
    public UndergraduateStudent(string name) : base(name) { }

    /// <summary>
    /// Calculates the GPA for the undergraduate student.
    /// </summary>
    /// <returns></returns>
    public override double CalculateGpa()
    {
        double totalGradePoints = 0.0;
        double totalCredits = 0.0;

       foreach (Course course in Courses)
        {
            double courseGrade = course.Grade;
            double courseCredit = course.Credit;
            double gradePoints = courseGrade * courseCredit;

            totalGradePoints += gradePoints;
            totalCredits += course.Credit;
        }

       if (totalCredits == 0)
        {
            return 0.0;
        }
       else
        {
            return totalGradePoints / totalCredits;
        }
    }
}
