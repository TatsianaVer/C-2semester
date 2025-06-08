using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    internal class BadWordFilter
    {
        /// <summary>
        /// List of prohibited words (case insensitive)
        /// </summary>
        private readonly List<string> _badwords = new List<string>();

        /// <summary>
        /// Adds a word to the list of prohibited words
        /// </summary>
        /// <param name="word">The word to add</param>
        public void Add(string word)
        {
            string normalizedWord = word.ToLower();

            bool found = false;

            for (int i = 0; i < _badwords.Count; i++)
            {
                if (_badwords[i] == normalizedWord)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                _badwords.Add(normalizedWord);
            }
        }

        /// <summary>
        /// Checks if a message contains any prohibited words
        /// </summary>
        /// <param name="message">The message to check</param>
        /// <returns>True if message contains prohibited words, false otherwise</returns>
        public bool ContainsBadWord(string message)
        {
            string normalizedMessage = message.ToLower();

            for (int i = 0; i < _badwords.Count;i++)
            {
                string badWord = _badwords[i];

                if (normalizedMessage.Contains(badWord))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
