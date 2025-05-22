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
    /// <param name="newDuration">The new duration of the lesson in minutes.</param>
    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("Science lesson duration updated.");
    }
    
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns>Type of the lesson</returns>
    protected override string GetLessonType()
    {
        return "Science";
    }
}
