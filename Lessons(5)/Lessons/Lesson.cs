﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a lesson with a topic and duration.
/// </summary>
public class Lesson
{
    /// <summary>
    /// Topic of the lesson.
    /// </summary>
    private string _topic;

    /// <summary>
    /// Duration of the lesson in minutes.
    /// </summary>
    private int _duration;

    /// <summary>
    /// Initializes a new instance of the <see cref="Lesson"/> class with the specified topic.
    /// </summary>
    /// <param name="topic">The topic of the lesson.</param>
    public Lesson(string topic)
    {
        _topic = topic;
    }

    /// <summary>
    /// Gets or sets the topic of the lesson.
    /// </summary>
    public string Topic
    {
        get
        {
            return _topic;
        }
        set
        {
            _topic = value;
        }
    }

    /// <summary>
    /// Gets the type of the lesson. Can be overridden by derived classes.
    /// </summary>
    protected virtual string LessonType
    {
        get
        {
            return LessonsConstants.Lesson;
        }
    }

    /// <summary>
    /// Outputs a message that the lesson has been conducted.
    /// </summary>
    public virtual void ConductLesson()
    {
        Console.WriteLine($"{LessonType} {LessonsConstants.Conducted}");
    }

    /// <summary>
    /// Changes the duration of the lesson.
    /// </summary>
    /// <param name="newDuration">New duration in minutes.</param>
    public virtual void ChangeDuration(int newDuration)
    {
        _duration = newDuration;
        Console.WriteLine($"{LessonsConstants.LessonTopic}\"{_topic}\" {LessonsConstants.DurationChanged}{_duration} {LessonsConstants.Minutes}");
        Console.WriteLine($"{LessonType} {LessonsConstants.DurationUpdated}");
    }

    protected virtual string GetLessonType()
    {
        return LessonsConstants.General;
    }
}
