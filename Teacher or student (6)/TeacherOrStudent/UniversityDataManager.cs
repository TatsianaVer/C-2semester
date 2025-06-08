using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Handles loading, processing and outputting university data.
/// </summary>
public class UniversityDataManager
{
    private List<Person> _people;
    private ApplicationSettings _settings;

    /// <summary>
    /// Constructor initializes list and settings.
    /// </summary>
    /// <param name="settings">Application settings instance.</param>
    public UniversityDataManager(ApplicationSettings settings)
    {
        _people = new List<Person>();
        _settings = settings;
    }

    /// <summary>
    /// Loads data from file and parses into people list.
    /// </summary>
    /// <returns>True if successful, false otherwise.</returns>
    public bool LoadDataFromFile()
    {
        string path = _settings.DataFilePath;

        if (!File.Exists(path))
        {
            Console.WriteLine(_settings.FileNotFoundMessage);
            return false;
        }

        try
        {
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] tokens = line.Split(_settings.DataSeparator);

                if (tokens.Length < 4)
                {
                    continue;
                }

                string lastName = tokens[0];
                int birthYear = Convert.ToInt32(tokens[1]);
                string status = tokens[2];

                if (status == _settings.StudentStatus)
                {
                    int[] grades = new int[tokens.Length - 3];

                    for (int j = 0; j < tokens.Length; j++)
                    {
                        grades[j - 3] = Convert.ToInt32(tokens[j]);
                    }

                    Student student = new Student(lastName, birthYear, status, grades, _settings);
                    _people.Add(student);
                }
                else if(status == _settings.TeacherStatus)
                {
                    int workload = Convert.ToInt32(tokens[3]);
                    Teacher teacher = new Teacher(lastName, birthYear, status, workload, _settings);
                    _people.Add(teacher);
                }
                else
                {
                    Person person = new Person(lastName, birthYear, status, _settings);
                    _people.Add(person);
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            string message = string.Format(_settings.FileReadErrorMessage, ex.Message);
            Console.WriteLine(message);
            return false;
        }
    }

    /// <summary>
    /// Sorts people by last name ascending.
    /// </summary>
    public void SortPeopleByLastName()
    {
        _people.Sort();
    }

    /// <summary>
    /// Prints the people data in tabular form with coloring for age > 19.
    /// </summary>
    /// <param name="header">Header to print before table.</param>
    public void PrintPeopleData(string header)
    {
        Console.WriteLine(header);

        string separator = _settings.HeaderSeparator;
        string tableSep = _settings.TableSeparator;
        string colSep = _settings.ColumnSeparator;

        string lastNameHeader = _settings.LastNameHeader.PadRight(_settings.ColumnWidth);
        string statusHeader = _settings.StatusHeader.PadRight(_settings.ColumnWidth);
        string addInfoHeader = _settings.AdditionalInfoHeader.PadRight(_settings.ColumnWidth);

        Console.WriteLine(tableSep + lastNameHeader + colSep + statusHeader + colSep + addInfoHeader + tableSep);
        Console.WriteLine(separator);

        for (int i = 0; i < _people.Count; i++)
        {
            Person person = _people[i];
            int age = person.GetAge();

            if (age > _settings.MinAgeForRedColor)
            {
                Console.ForegroundColor = _settings.WarningColor;
            }
            else
            {
                Console.ResetColor();
            }

            string lastName = person.LastName.PadRight(_settings.ColumnWidth);
            string status = person.Status.PadRight(_settings.ColumnWidth);
            string addInfo = person.GetAdditionalInfo().PadRight(_settings.ColumnWidth);

            Console.WriteLine(tableSep + lastName + colSep + status + colSep + addInfo + tableSep);
            Console.ResetColor();
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Finds and prints students with at least two excellent grades.
    /// </summary>
    public void PrintStudentsWithMultipleExcellentGrades()
    {
        int excellentGradeThreshold = _settings.ExcellentGrade;

        Console.WriteLine(_settings.StudentsWithExcellentGradesHeader);

        List<Student> excellentStudents = new List<Student>();

        for (int i = 0; i < _people.Count; i++)
        {
            Person person = _people[i];

            if (person is Student)
            {
                Student student = (Student)person;
                int countExcellent = student.CountExcellentGrades();

                if (countExcellent >= 2)
                {
                    excellentStudents.Add(student);
                }
            }
        }

        if (excellentStudents.Count == 0)
        {
            Console.WriteLine(_settings.NoExcellentStudentsMessage);
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < excellentStudents.Count; i++)
        {
            Student student = excellentStudents[i];
            int countExcellent = student.CountExcellentGrades();

            string line = string.Format(_settings.ExcellentGradesFormat, student.LastName, countExcellent);
            Console.WriteLine(line);
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Finds and prints maximum workload among teachers older than 40.
    /// </summary>
    public void PrintMaxWorkloadForTeachersOverAge()
    {
        int minAge = _settings.MinAgeWorkloadCheck;
        int maxWorkload = 0;

        for (int i = 0; i < _people.Count; i++)
        {
            Person person = _people[i];

            if (person is Teacher)
            {
                int age = person.GetAge();

                if (age > minAge)
                {
                    Teacher teacher = (Teacher)person;

                    if (teacher.WorkloadHours > maxWorkload)
                    {
                        maxWorkload = teacher.WorkloadHours;
                    }
                }
            }
        }

        string message = string.Format(_settings.MaxWorkloadMessage, maxWorkload);
        Console.WriteLine(message);
        Console.WriteLine();
    }
}
