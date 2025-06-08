using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// <inheritdoc/>
/// </summary>
public class ScienceLesson : Lesson
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="topic"></param>
    public ScienceLesson(string topic) : base(topic) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="newDuration"></param>
    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine($"{Topic} {LessonsConstants.DurationUpdated}");
    }

    protected override string GetLessonType()
    {
        return $"{Topic}";

    }
}

