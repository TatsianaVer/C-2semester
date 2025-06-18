using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LessonsConstants.MathLessonTheme);
        MathLesson math = new MathLesson(Console.ReadLine());

        Console.WriteLine(LessonsConstants.ScienceLessonTheme);
        ScienceLesson science = new ScienceLesson(Console.ReadLine());

        Console.WriteLine(LessonsConstants.HistoryLessonTheme); 
        HistoryLesson history = new HistoryLesson(Console.ReadLine());

        Console.WriteLine(LessonsConstants.MathLessonDuration);
        var durationMath = Console.ReadLine();
        int mathDuration = int.Parse(durationMath);
        math.ChangeDuration(mathDuration);
        math.ConductLesson();

        Console.WriteLine(LessonsConstants.ScienceLessonDuration);
        var durationScience = Console.ReadLine();
        int scienceDuration = int.Parse(durationScience);
        science.ChangeDuration(scienceDuration);
        science.ConductLesson();

        Console.WriteLine(LessonsConstants.HistoryLessonDuration);
        var durationHistory = Console.ReadLine();
        int historyDuration = int.Parse(durationHistory);
        history.ChangeDuration(historyDuration);
        history.ConductLesson();

        Console.WriteLine($"\n {math}: {mathDuration}" +
            $"\n {science}: {scienceDuration}" +
            $"\n {history}: {historyDuration}");
    }
}

