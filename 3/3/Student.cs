using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Abstract base class representing a student.
/// </summary>
public abstract class Student
{
    /// <summary>
    /// Stores the name, credit and grade of the student.
    /// </summary>
    private string _name;
    private double _credit;
    private double _grade;

    /// <summary>
    /// List of courses the student has taken.
    /// </summary>
    private readonly List<Course> _courses = new List<Course>();

    /// <summary>
    /// Gets the name of the student.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// </summary>
    /// <param name="name">Name of the student.</param>
    protected Student(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Adds a course with the specified name, credit, and grade.
    /// </summary>
    /// <param name="name">Name of the course.</param>
    /// <param name="credit">Credit value of the course.</param>
    /// <param name="grade">Grade received in the course.</param>
    public void AddCourse(string name, double credit, double grade)
    {
        Course course = new Course(name, credit, grade);

        _courses.Add(course);
    }

    /// <summary>
    /// Calculates the GPA.
    /// </summary>
    /// <returns>The GPA value.</returns>
    public abstract double CalculateGpa();

    /// <summary>
    /// Gets the list of courses.
    /// </summary>
    protected IEnumerable<Course> Courses
    {
        get
        {
            return _courses;
        }
    }
}