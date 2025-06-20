﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a PhD student, inheriting from Student.
/// </summary>
public class PhdStudent : Student
{
    /// <summary>
    /// Weight multiplier for research courses.
    /// </summary>
    private const double ResearchWeight = 1.5;

    /// <summary>
    /// Initializes a new instance of the <see cref="PhdStudent"/> class with the specified name.
    /// </summary>
    /// <param name="name">Name of the PhD student.</param>
    public PhdStudent(string name) : base(name) { }

    public override double CalculateGpa()
    {
        double totalWeightedPoints = 0.0;
        double totslWeightedCredits = 0.0;

        foreach (var course in Courses)
        {
            double weight = 1.0;

            if (course.Name.StartsWith("Research"))
            {
                weight = ResearchWeight;
            }

            totalWeightedPoints += course.Grade * course.Credit * weight;
            totslWeightedCredits += course.Credit * weight;
        }

        if (totslWeightedCredits == 0)
        {
            return 0;
        }

        return totalWeightedPoints / totslWeightedCredits;
    }
}

