using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    /// <summary>
    /// The main method that creates lesson instances, conducts them, and changes their duration.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    public static void Main(string[] args)
    {
        MathLesson math = new MathLesson("Algebra");
        ScienceLesson science = new ScienceLesson("Physics");
        HistoryLesson history = new HistoryLesson("Middle Ages");

        math.ConductLesson();
        science.ConductLesson();
        history.ConductLesson();

        math.ChangeDuration(45);
        science.ChangeDuration(50);
        history.ChangeDuration(40);
    }
}
