using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Fill
    {
        public void Execute(Arr arr)
        {
            Console.Write("Enter elements: ");
            var input = Console.ReadLine()?.Split(' ');

            if (input == null || input.Length != arr.Data.Length)
                throw new InvalidOperationException("Invalid count");

            for (int i = 0; i < arr.Data.Length; i++)
            {
                if (!double.TryParse(input[i], out arr.Data[i]))
                    throw new FormatException($"Parse error: {input[i]}");
            }
        }
    }
}
