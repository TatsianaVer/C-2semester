﻿using Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayManager
    {
        private int[] _data;

        public int[] Data => _data;

        public void ReadFromInput()
        {
            Console.WriteLine(AppConstants.EnterArrayElements);

            var input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException(AppConstants.EmptyArrayError);
            }

            try
            {
                _data = input.Split(' ').Select(s => int.Parse(s)).ToArray();
            }
            catch(FormatException)
            {
                throw new FormatException(AppConstants.InvalidInputMessage);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{AppConstants.Array}" +
                $"{string.Join(" ", _data)}");
        }

        private void ValidateNonEmpry()
        {
            if (_data.Length == 0)
            {
                throw new InvalidOperationException(AppConstants.EmptyArrayError);
            }
        }

        public int FindFirstMinIndex()
        {
            ValidateNonEmpry();
            return Array.IndexOf(_data, _data.Min());
        }

        public int FindLastMinIndex()
        {
            ValidateNonEmpry();
            return Array.IndexOf(_data, _data.Max());
        }
    }
}
