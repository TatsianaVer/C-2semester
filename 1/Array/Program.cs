using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Program
    {
        public static void Main1()
        {
            try
            {
                var a = new Arr(5);
                var b = new Arr(5);

                Console.WriteLine("Array A:");
                new Fill().Execute(a);

                Console.WriteLine("Array B:");
                new Fill().Execute(b);

                var c = new MakeC().Execute(a, b, 3);

                Console.WriteLine("\nResults:");
                Show(a, "A");
                Show(b, "B");
                Show(c, "C");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void Show(Arr arr, string name)
        {
            new Print().Execute(arr);
            Console.WriteLine($"{name}: Product = {new NegProd().Execute(arr)}\n");
        }
    }
}
