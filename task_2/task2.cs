using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISM;

namespace task_2
{
    class task2
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введiть число n(показник): ");
            int n = int.Parse(Console.ReadLine());
            library solver = new library();
            double degree = solver.Degree(n, a);
            Console.WriteLine("a в степенi n дорiвнює = " + degree);
        }
    }
}
