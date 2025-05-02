using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Errors
    {
        public static void ShowError(string message)
        {
            Console.WriteLine($"\n{AppConstants.Error} {message}");
        }

        public static void HoldScreen()
        {
            Console.WriteLine($"\n", AppConstants.PressKey);
        }
    }
}
