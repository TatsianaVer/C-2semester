using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    public class TextAnalyzer
    {
        /// <summary>
        /// The text to analyze.
        /// </summary>
        private readonly string _text;

        /// <summary>
        /// Characters used as separators to split the text into words.
        /// </summary>
        private readonly char[] _separators = { ' ', ',', '.', '\n', '\r' };

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalyzer"/> class.
        /// </summary>
        /// <param name="text">The text to be analyzed</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="text"/> is null.</exception>
        public TextAnalyzer(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            _text = text;
        }

        /// <summary>
        /// Gets the number of occurrences of the longest words in the text.
        /// </summary>
        /// <returns>The count of words that have the maximum length.</returns>
        public int GetLongestWordOccurrences()
        {
            List<string> words = GetWords();

            if (words.Count == 0)
            {
                return 0;
            }

            int maxLength = words.Max(w => w.Length);

            int count = words.Count(w => w.Length == maxLength);
            return count;
        }

        /// <summary>
        /// Returns a string with each word enclosed in parentheses and concatenated.
        /// </summary>
        /// <returns>A concatenated string of all words wrapped in parentheses.</returns>
        public string GetBracketedWordsString()
        {
            List<string> words = GetWords();

            IEnumerable<string> bracketedWords = words.Select(w => $"({w})");

            string result = string.Join("", bracketedWords);
            return result;
        }

        /// <summary>
        /// Splits the text into a list of words based on separators, removing empty or whitespace-only entries.
        /// </summary>
        /// <returns>A list of non-empty, trimmed words.</returns>
        private List<string> GetWords()
        {
            string[] splitWords = _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            
            IEnumerable<string> filteredWords = splitWords.Where(w => !string.IsNullOrWhiteSpace(w));

            List<string> wordList = filteredWords.ToList();

            return wordList;
        }
    }
}
