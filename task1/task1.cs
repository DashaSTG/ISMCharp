using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISM;

namespace task1
{
    class task1
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число: ");
            int n = int.Parse(Console.ReadLine());
            library solver = new library();
            double sum = solver.CalculateSum(n);
            Console.WriteLine("Сума довiвнює = " + sum);


        }
    }
}
