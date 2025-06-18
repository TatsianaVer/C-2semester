using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person : IComparable<Person>
{
    /// <summary>
    ///  Represents a person with basic data: last name, birth year, and status.
    ///  Implements IComparable for sorting by last name.
    /// </summary>
    private string _lastName;
    private int _birthYear;
    private ApplicationSettings _settings;
    private string _status;

    /// <summary>
    /// Constructor that initializes a Person object.
    /// </summary>
    /// <param name="lastName">Last name of the person.</param>
    /// <param name="birthYear">Birth year of the person.</param>
    /// <param name="status">Status of the person (e.g., student, teacher).</param>
    /// <param name="settings">Application settings.</param>
    public Person(string lastName, int birthYear, string status, ApplicationSettings settings)
    {
        _lastName = lastName;
        _birthYear = birthYear;
        _status = status;
        _settings = settings;
    }

    /// <summary>
    /// Gets or sets the last name of the person.
    /// </summary>
    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value;
        }
    }

    /// <summary>
    /// Gets or sets the birth year of the person.
    /// </summary>
    public int BirthYear
    {
        get
        {
            return _birthYear;
        }
        set
        {
            _birthYear = value;
        }
    }

    /// <summary>
    /// Gets or sets the status of the person.
    /// </summary>
    public string Status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }

    /// <summary>
    /// Virtual method that calculates the age of the person.
    /// </summary>
    /// <returns>Age in years.</returns>
    public virtual int GetAge()
    {
        int age = _settings.CurrentYear - _birthYear;
        return age;
    }

    /// <summary>
    /// Virtual method to get additional information about the person.
    /// By default, returns age info.
    /// </summary>
    /// <returns>String with additional information.</returns>
    public virtual string GetAdditionalInfo()
    {
        int age = GetAge();
        string info = string.Format(_settings.AgeInfoFormat, age);
        return info;
    }

    /// <summary>
    /// Compares this person to another person by last name for sorting.
    /// </summary>
    /// <param name="other">Another Person to compare to.</param>
    /// <returns>Integer indicating sorting order.</returns>
    public int CompareTo(Person other)
    {
        if (other == null)
        {
            return 1;
        }

        int result = string.Compare(this._lastName, other._lastName, StringComparison.Ordinal);
        return result;
    }
}


