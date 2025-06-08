using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Program
    {
        public static void Main()
        {
            Chat chat = new Chat(ChatConstants.MyChat);

            Console.WriteLine(ChatConstants.InitialState);
            Console.WriteLine(chat.GetChatInfo());
        }
    }
}
