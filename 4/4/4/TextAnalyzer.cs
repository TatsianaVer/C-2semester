using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessor
{
    public class TextAnalyzer
    {
        private readonly string _text;
        private readonly char[] _separators = { ' ', ',', '.', '\n', '\r' };

        public TextAnalyzer(string text)
        {
            _text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public int GetLongestWordOccurrences()
        {
            var words = GetWords();
            if (words.Count == 0) return 0;

            var maxLength = words.Max(w => w.Length);
            return words.Count(w => w.Length == maxLength);
        }

        public string GetBracketedWordsString()
        {
            var words = GetWords();
            return string.Join("", words.Select(w => $"({w})"));
        }

        private List<string> GetWords()
        {
            return _text.Split(_separators, StringSplitOptions.RemoveEmptyEntries)
                        .Where(w => !string.IsNullOrWhiteSpace(w))
                        .ToList();
        }
    }
}
