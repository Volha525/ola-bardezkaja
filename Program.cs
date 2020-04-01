using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(int.MinValue, int.MaxValue);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            int negativeIndex = -1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }

            string message = negativeIndex >= 0 ?
                 $"это число {array[negativeIndex]} и индекс {negativeIndex} " : "Отрицательных чисел нет";

            Console.WriteLine(message);
            Console.Read();
        }
    }
}
