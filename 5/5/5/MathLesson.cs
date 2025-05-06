using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathLesson : Lesson
{
    public MathLesson(string topic) : base(topic)
        { }

    public void ConductLesson()
    {
        Console.WriteLine("Math lesson conducted.");
    }

    public override void ChangeDuration(int newDuration)
    {
        base.ChangeDuration(newDuration);
        Console.WriteLine("Math lesson duration updated.");
    }
}