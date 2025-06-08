using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    internal class UserList
    {
        /// <summary>
        /// Internal storage for users
        /// </summary>
        private readonly List<string> _users = new List<string>();

        /// <summary>
        /// Gets current number of users
        /// </summary>
        public int Count
        {
            get
            {
                return _users.Count;
            }
        }

        /// <summary>
        /// Adds unique username
        /// </summary>
        /// <param name="username">Username to add</param>
        public void Add (string username)
        {
            bool userExists = false;

            foreach (string existingUser  in _users)
            {
                if (existingUser.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    userExists = true;
                    break;
                }
            }

            if (!userExists == false)
            {
                _users.Add(username);
            }
        }

        /// <summary>
        /// Removes all instances of username
        /// </summary>
        /// <param name="username">Username to remove</param>
        public void Remove(string username)
        {
            _users.RemoveAll(u => u.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            return string.Join(", ", _users);
        }
    }
}
