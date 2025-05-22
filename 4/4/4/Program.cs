using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    /// <summary>
    /// Entry point of the program demonstrating usage of the <see cref="TextAnalyzer"/> class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method which creates a <see cref="TextAnalyzer"/> instance,
        /// analyzes the text, and prints the results to the console.
        /// </summary>
        public static void Main()
        {
            var text = "Hello world. Hello everyone! This is a test, hello?";
            var analyzer = new TextAnalyzer(text);

            Console.WriteLine($"Longest word count: {analyzer.GetLongestWordOccurrences()}");
            Console.WriteLine($"Bracketed string: {analyzer.GetBracketedWordsString()}");
        }
    }
}
