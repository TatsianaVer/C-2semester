using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a student, derived from Person, with grades.
/// </summary>
public class Student : Person
    {
    private int[] _grades;
    private ApplicationSettings _settings;

    /// <summary>
    /// Constructor that initializes a Student object.
    /// </summary>
    /// <param name="lastName">Last name.</param>
    /// <param name="birthYear">Birth year.</param>
    /// <param name="status">Status, should be 'student'.</param>
    /// <param name="grades">Array of grades.</param>
    /// <param name="settings">Application settings.</param>
    public Student(string lastName, int birthYear, string status, int[] grades, ApplicationSettings settings)
        : base(lastName, birthYear, status, settings)
    {
        _grades = new int[grades.Length];
        for (int i = 0; i < grades.Length; i++)
        {
            _grades[i] = grades[i];
        }

        _settings = settings;
    }

    /// <summary>
    /// Gets or sets the grades array.
    /// </summary>
    public int[] Grades
    {
        get
        {
            int[] copyGrades = new int[_grades.Length];
            for (int i = 0; i < _grades.Length; i++)
            {
                copyGrades[i] = _grades[i];
            }
            return copyGrades;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(_settings.NullGradesArray);
            }

            _grades = new int[value.Length];
            for (int i = 0;i < value.Length;i++)
            {
                _grades[i] = value[i];
            }
        }
    }

    /// <summary>
    /// Calculates the average grade of the student.
    /// </summary>
    /// <returns>Average grade as double.</returns>
    public double CalculateAverageGrade()
    {
        int sum = 0;
        int count = _grades.Length;

        for (int i = 0; i < count; i++)
        {
            sum = sum + _grades[i];
        }

        double average = 0.0;

        if (count > 0)
        {
            average = (double)sum / count;
        }

        return average;
    }

    /// <summary>
    /// Counts the number of excellent grades (>= ExcellentGrade setting).
    /// </summary>
    /// <returns></returns>
    public int CountExcellentGrades()
    {
        int count = 0;
        int threshold = _settings.ExcellentGrade;

        for (int i = 0; i < _grades.Length; i++)
        {
            if (_grades[i] >= threshold)
            {
                count = count + 1;
            }
        }
        return count;
    }

    /// <summary>
    /// Overrides the GetAdditionalInfo to include average grade info.
    /// </summary>
    /// <returns>String with average grade info.</returns>
    public override string GetAdditionalInfo()
    {
        double averageGrade = CalculateAverageGrade();
        string info = string.Format(_settings.AverageGradeFormat, averageGrade);
        return info;
    }
}
