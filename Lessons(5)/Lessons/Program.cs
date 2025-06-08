using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Math lesson theme");
        MathLesson math = new MathLesson(Console.ReadLine());

        Console.WriteLine("Enter Science lesson theme");
        ScienceLesson science = new ScienceLesson(Console.ReadLine());

        Console.WriteLine("Enter History lesson theme"); 
        HistoryLesson history = new HistoryLesson(Console.ReadLine());

        Console.WriteLine("Enter Math lesson duration");
        var durationMath = Console.ReadLine();
        int mathDuration = int.Parse(durationMath);
        math.ChangeDuration(mathDuration);
        math.ConductLesson();

        Console.WriteLine("Enter Science lesson duration");
        var durationScience = Console.ReadLine();
        int scienceDuration = int.Parse(durationScience);
        science.ChangeDuration(scienceDuration);
        science.ConductLesson();

        Console.WriteLine("Enter History lesson duration");
        var durationHistory = Console.ReadLine();
        int historyDuration = int.Parse(durationHistory);
        history.ChangeDuration(historyDuration);
        history.ConductLesson();

        Console.WriteLine($"\n {math}: {mathDuration}" +
            $"\n {science}: {scienceDuration}" +
            $"\n {history}: {historyDuration}");
    }
}

