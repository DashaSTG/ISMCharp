using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISM;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число n: ");

            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            Random arr = new Random();
            for (int i = 0; i < n; i++)
                array[i] = arr.Next(-1000, 1000);

            for (int i = 0; i < n - 1; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine(array[n - 1]);

                library solver = new library();

            double SumnegativeNumb =solver.Array_SumNegativeNumb(array);
            Console.WriteLine("Сума вiд'ємних елементiв = " + SumnegativeNumb);

            double MaxNumb = solver.Array_MaxNumb(array);
            Console.WriteLine("Найбiльше за модулем число = " + MaxNumb);


            int SumIndexes = solver.Array_SumIndexes(array);
            Console.WriteLine("Cума iндексiв додатнiх елементiв = " + SumIndexes);


            int IntengerQuantity = solver.Array_IntengerQuantity(array);
            Console.WriteLine("Кiлькiсть цiлих чисел = " + IntengerQuantity);


            double sumMax_Min = solver.Array_SumMax_Min(array);
            Console.WriteLine("Добуток елементiв масиву мiж Max i Min = " + sumMax_Min);


            int variablecoun = solver.Array_DifferentNumbs(array);
            Console.WriteLine("Кiлькiсть рiзних чисел = " + variablecoun);









        }
    }
}
