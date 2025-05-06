using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ScienceLesson : Lesson
{
    public ScienceLesson(string topic) : base(topic)
    {
    }

    public void ConductLesson()
    {
        Console.WriteLine("Science lesson conducted.");
    }

    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("Science lesson duration updated.");
    }
}
