using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HistoryLesson : Lesson
{
    public HistoryLesson(string topic) : base(topic)
    {
    }

    public void ConductLesson()
    {
        Console.WriteLine("History lesson conducted.");
    }

    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("History lesson duration updated.");
    }
}

