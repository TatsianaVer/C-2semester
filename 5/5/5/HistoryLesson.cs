using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a history lesson.
/// </summary>
public class HistoryLesson : Lesson
{
    /// <summary>
    ///<inheritdoc/>
    /// </summary>
    /// <param name="topic">The topic of the history lesson.</param>
    public HistoryLesson(string topic) : base(topic) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="newDuration">Updated duration.</param>
    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("History lesson duration updated.");
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    protected override string GetLessonType()
    {
        {
            return "History";
        }
    }
}

