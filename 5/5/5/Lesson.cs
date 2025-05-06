using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lesson
{
    private string _topic;
    private int _duration;

    public Lesson(string topic)
    {
        _topic = topic;
    }

    public string Topic
    {
        get => _topic;
        set => _topic = value;
    }

    public virtual void ChangeDuration(int newDuration)
    {
        _duration = newDuration;
        Console.WriteLine($"Lesson on topic \"{_topic}\" duration changed to {_duration} minutes.");
    }
}
