using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    public class Program
    {
        public static void Main()
        {
            var text = "Hello world. Hello everyone! This is a test, hello?";
            var analyzer = new TextAnalyzer(text);

            Console.WriteLine($"Longest word count: {analyzer.GetLongestWordOccurrences()}");
            Console.WriteLine($"Bracketed string: {analyzer.GetBracketedWordsString()}");
        }
    }
}
