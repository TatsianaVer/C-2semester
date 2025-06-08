using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a math lesson.
/// </summary>
internal class MathLesson : Lesson
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="topic">The topic of the math lesson.</param>
    public MathLesson(string topic) : base(topic) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="newDuration">Lesson duration</param>
    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine($"{Topic} {LessonsConstants.DurationUpdated}");
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override string GetLessonType()
    {
        return $"{Topic}";
    }
}

