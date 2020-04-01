using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterAa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string sentense = Console.ReadLine();
            char[] charSentense = sentense.ToCharArray();
            char a = 'а';
            char A = 'А';

            for (int i = 0; i < charSentense.Length; i++)
            {
                if (charSentense[i] == a)
                {
                   charSentense[i] = A;
                    
                }
                
            }
            sentense = new string(charSentense);
            Console.WriteLine($"Новое предложение: {sentense}");
            Console.ReadLine();
        }
    }
}
