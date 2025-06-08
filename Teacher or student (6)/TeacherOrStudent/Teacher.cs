using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a teacher, derived from Person, with workload info.
/// </summary>
public class Teacher : Person
{
    public int _workloadHours;
    private ApplicationSettings _settings;

    /// <summary>
    /// Constructor to initialize Teacher.
    /// </summary>
    /// <param name="lastName">Last name.</param>
    /// <param name="birthYear">Birth year.</param>
    /// <param name="status">Status, should be 'teacher'.</param>
    /// <param name="workloadHours">Workload in hours.</param>
    /// <param name="settings">Application settings.[</param>
    public Teacher(string lastName, int birthYear, string status, int workloadHours, ApplicationSettings settings)
        : base(lastName, birthYear, status, settings)
    {
        _workloadHours = workloadHours;
        _settings = settings;
    }

    /// <summary>
    /// Gets or sets the workload hours.
    /// </summary>
    public int WorkloadHours
    {
        get
        { 
            return _workloadHours;        
        }
        set
        {
            _workloadHours = value;
        }
    }

    public override string GetAdditionalInfo()
    {
        string info = string.Format(_settings.WorkloadInfoFormat, _workloadHours);
        return info;
    }
}
