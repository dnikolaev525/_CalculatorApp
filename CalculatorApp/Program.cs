using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Результат сложения: {a + b}");
        }
    }
}
