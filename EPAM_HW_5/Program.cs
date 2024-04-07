using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_5
{
    internal class Program
    {
        static double sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.Write("First number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double b = double.Parse(Console.ReadLine());
            double c =sum(a, b);
            Console.WriteLine($"Average: {c / 2}");
        }
    }
}
