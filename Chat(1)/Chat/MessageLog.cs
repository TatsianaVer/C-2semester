using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    internal class MessageLog
    {
        private readonly List<string> _messages = new List<string>();
        private readonly BadWordFilter _badWordFilter;

        /// <summary>
        /// Initializes a new instance of the MessageLog class.
        /// </summary>
        /// <param name="badWordFilter">The bad word filter instance to check messages against.</param>
        public MessageLog(BadWordFilter badWordFilter)
        {
            _badWordFilter = badWordFilter;
        }

        /// <summary>
        /// Gets the total number of messages in the log.
        /// </summary>
        public int Count
        {
            get
            { 
                return _messages.Count;
            }
        }

        public bool Add(string username, string message)
        {
            bool containsBadWords = _badWordFilter.ContainsBadWord(message);

            if (containsBadWords)
            {
                return false;
            }

            string formattedMessage = string.Format("{0}: {1}", username, message);
            _messages.Add(formattedMessage);

            return true;
        }
    }
}
