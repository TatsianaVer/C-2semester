using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a course with a name, credit hours, and a grade.
/// </summary>
public class Course
{
    /// <summary>
    /// Private backing field for the Name property.
    /// </summary>
    private readonly string _name;

    /// <summary>
    /// Private backing field for the Credit property.
    /// </summary>
    private readonly double _credit;

    /// <summary>
    /// Private backing field for the Grade property.
    /// </summary>
    private readonly double _grade;

    /// <summary>
    /// Gets the name of the course.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
    }

    /// <summary>
    /// Gets the credit hours of the course.
    /// </summary>
    public double Credit
    {
        get
        {
            return _credit;
        }
    }

    /// <summary>
    /// Gets the grade for the course.
    /// </summary>
    public double Grade
    {
        get
        {
            return _grade;
        }
    }

    /// <summary>
    /// Initializes a new instance of the Course class with the specified name, credit, and grade.
    /// </summary>
    /// <param name="name">The name of the course.</param>
    /// <param name="credit">The number of academic credits for the course.</param>
    /// <param name="grade">The grade received for the course.</param>
    public Course(string name, double credit, double grade)
    {
        _name = name;
        _credit = credit;
        _grade = grade;
    }
}

