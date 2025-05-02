using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    internal class UserList
    {
        private readonly List<string> _users = new List<string>();

        public int Count => _users.Count;

        public void Add(string username)
        {
            if (!_users.Any(u => u.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                _users.Add(username);
            }
        }

        public void Remove(string username)
        {
            _users.RemoveAll(u => u.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString() => string.Join(", ", _users);
    }
}
