using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Chat
    {
        /// <summary>
        /// Chat name (readonly after initialization)
        /// </summary>
        private readonly string _chatName;

        /// <summary>
        /// List of chat users
        /// </summary>
        private readonly UserList _users = new UserList();

        /// <summary>
        /// Filter for prohibited words
        /// </summary>
        private readonly BadWordFilter _badWordFilter = new BadWordFilter();

        /// <summary>
        /// Log of all chat messages
        /// </summary>
        private readonly MessageLog _messageLog;

        /// <summary>
        /// Creates new chat
        /// </summary>
        /// <param name="chatName">Name for the chat</param>
        /// <exception cref="ArgumentException"></exception>
        public Chat(string chatName)
        {
            if (string.IsNullOrEmpty(chatName))
            {
                throw new ArgumentException(ChatConstants.ChatNameError, nameof(chatName));
            }

            _chatName = chatName;
            _messageLog = new MessageLog(_badWordFilter);
        }

        /// <summary>
        /// Gets chat name
        /// </summary>
        public string ChatName
        {
            get
            {
                return _chatName;
            }
        }

        /// <summary>
        /// Gets current number of users
        /// </summary>
        public int UsersCount
        {
            get
            { 
                return _users.Count;
            }
        }

        /// <summary>
        /// Gets total messages count
        /// </summary>
        public int MessagesCount
        {
            get
            {
                return _messageLog.Count;
            }
        }

        /// <summary>
        /// Adds user to chat
        /// </summary>
        /// <param name="username">Username to add</param>
        public void AddUser(string username)
        {
            _users.Add(username);
        }

        /// <summary>
        /// Removes user from chat
        /// </summary>
        /// <param name="username">Username to remove</param>
        public void RemoveUser(string username)
        {
            _users.Remove(username);
        }

        /// <summary>
        /// Adds message to chat if it passes filters
        /// </summary>
        /// <param name="username">Sender username</param>
        /// <param name="message">Message content</param>
        /// <returns>True if message was added successfully</returns>
        public bool AddMessage(string username, string message)
        {
            return _messageLog.Add(username, message);
        }

        /// <summary>
        /// Adds word to prohibited words list
        /// </summary>
        /// <param name="badWord">Word to block</param>
        public void AddBadWord(string badWord)
        {
            _badWordFilter.Add(badWord);
        }

        public string GetChatInfo()
        {
            string participants;

            if (UsersCount > 0)
            {
                participants = _users.ToString();
            }
            else
            {
                participants = ChatConstants.None;
            }

            string chatInfo =
                ChatConstants.Chat + ": " + ChatName + ", " +
                ChatConstants.Users + ": " + UsersCount.ToString() + ", " +
                ChatConstants.Messages + ": " + MessagesCount.ToString() + ", " +
                ChatConstants.Participants + ": " + participants;

            return chatInfo;
        }
    }
}
