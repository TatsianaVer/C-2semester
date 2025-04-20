using System;
using Variant11;
using University;

namespace EntryPoint
{
    public class Menu
    {
        public static void Main()  // Это будет точка входа
        {
            while (true)
            {
                Console.WriteLine("\n=== Select Program ===");
                Console.WriteLine("1. Array Processor");
                Console.WriteLine("2. Teacher Processor");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Variant11.Program.Main1();  // Запуск Variant11
                        break;
                    case "2":
                        University.Program.Main2();  // Запуск University
                        break;
                    case "0":
                        return;  // Выход
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}

