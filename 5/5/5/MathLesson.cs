using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Represents a math lesson.
/// </summary>
public class MathLesson : Lesson
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="topic">The topic of the math lesson.</param>
    public MathLesson(string topic) : base(topic) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="newDuration"></param>
    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("Math lesson duration updated.");
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    protected override string GetLessonType()
    {
        return "Math";
    }
}