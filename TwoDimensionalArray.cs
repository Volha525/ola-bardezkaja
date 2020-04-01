using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] array = new int[10, 10];
            int i = 0;
            int j = 0;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    array[i, j] = r.Next(-100, 100);
                }
            }

            PrintArray(array);

            for (i = 0; i < 10; i++)
            {
                int m = 0;
                for (j = 0; j < 10; j++)
                {
                    if (array[i, j] > array[i, m])
                    {
                        m = j;
                    }
                }
                for (j = m + 1; j < 10; j++)
                {
                    array[i, j] = 0;
                }
            }
            Console.WriteLine();
            PrintArray(array);
            Console.ReadKey();
        }

        static void PrintArray (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string numbers = string.Empty;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    numbers += $"{array[i, j]}\t";
                    
                }
                Console.WriteLine(numbers);
            }
        }
    }

}

