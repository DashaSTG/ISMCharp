using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM
{
    public class library
    {
        public double CalculateSum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + 1.0 / i;
            }
            return sum;
        }

        public double Degree(int n, double a)
        {
            double degree = 1;
            for (int i = 1; i <= n; i++)
            {
                degree = degree * a;
            }
            return degree;
        }

        public double Array_SumNegativeNumb(double[] array) //сума від'ємних елементів
        {
            double SumNegativeNumb = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    SumNegativeNumb += array[i];
            }
            return SumNegativeNumb;
        }

        public double Array_MaxNumb(double[] array) //найбільше за модулем число
        {
            double ABSmaxnumb = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > ABSmaxnumb)
                    ABSmaxnumb = Math.Abs(array[i]);
            }
            return ABSmaxnumb;
        }

        public int Array_SumIndexes(double[] array) //сума індексів додатніх елементів
        { 
            int SumIndexes = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    SumIndexes += i;
            }
            return SumIndexes;
        }

        public int Array_IntengerQuantity(double[] array) //кількість цілих чисел
        {
            int IntengerQuantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 1 == 0)
                    IntengerQuantity++;
            }
            return IntengerQuantity;
        }

        public double Array_SumMax_Min(double[] array) //добуток елементів масиву між Max i Min
        {
            double maxnumb = array[0];
            double minnumb = array[0];
            int indexmin = 0;
            int indexmax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxnumb)//найбільше число
                {
                    maxnumb = array[i];
                    indexmax = i;
                }

                if (array[i] < minnumb) //найменше число
                {
                    minnumb = array[i];
                    indexmin = i;
                }
            }

            double sumMax_Min = 1;
            for (int i = Math.Min(indexmin, indexmax); i <= Math.Max(indexmin, indexmax); i++)
                sumMax_Min *= array[i];

            return sumMax_Min;
        }

        public int Array_DifferentNumbs(double[] array) //кількість різних чисел
        {
            int variablecoun = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                        break;

                    variablecoun++;
                }
            }
            return variablecoun;
        }








    }
}
