using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vovels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string sentens = Console.ReadLine();
            string vovels = "аАоОуУыЫэЭяЯёЁюЮиИеЕ";
            int vovelSum = 0;

            for (int i = 0; i < sentens.Length; i++)
            {
                for (int j = 0; j < vovels.Length; j++)
                {
                    if (sentens[i] == vovels[j])
                    {
                        vovelSum += 1;
                        break;
                    }

                }

            }
            Console.WriteLine($"Количество глассных {vovelSum}");
            Console.Read();
        }
    }
}
