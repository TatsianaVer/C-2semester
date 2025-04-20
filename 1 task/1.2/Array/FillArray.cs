using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant15
{
    public class FillArray
    {
        public static void Execute(Array arr)
        {
            Console.Write("Enter the array elements separated by spaces: ");
            var input = Console.ReadLine()?.Split(' ');

            if (input == null || input.Length != arr.Data.Length)
                throw new InvalidOperationException("Invalid number of elements");

            for (int i = 0; i < arr.Data.Length; i++)
            {
                if (!double.TryParse(input[i], out arr.Data[i]))
                    throw new FormatException($"Parsing error: {input[i]}");
            }
        }
    }
}
