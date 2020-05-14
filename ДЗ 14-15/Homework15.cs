using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Reverse 5647:");
			Reverse(5647);
			Console.WriteLine();
			Console.Write("Array:");
			int[] numbers = new int[6] { 5, -3, 7, 6, 2, 0 };
			foreach(int i in numbers)
			{
				Console.Write($"{i}\t");
			}
			Console.WriteLine();
			Console.Write("Show numbers that are(is) bigger then the number before:");
			GetSomeNumbers(numbers);
			Console.WriteLine();
			Console.Write("Numbers with changed sign:");
			ChangeEverySign(numbers);
			Console.WriteLine();
			Console.WriteLine("Arithmetic Progression:");
			ArithmeticProgression(4, 2, 10);
			Console.WriteLine();
			Console.WriteLine("Geometric Progression:");
			GeometricProgression(1, 2, 5);
			Console.WriteLine();

			Console.ReadLine();
		}

		public static void Fibonachi(int n)
		{
			int[] fibonachi = new int[n];
			fibonachi[0] = 0;
			fibonachi[1] = 1;
			for (int i = 2; i < n; i++)
			{
				fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
				Console.WriteLine(fibonachi[i]);
			}
		}

		public static void Reverse(int number)
		{
			int number1 = number;
			int counter = 0;
			while (number1 > 0)
			{
				counter++;
				number1 /= 10;
			}

			int[] reverseNumber = new int[counter];
			for (int i = counter - 1; i >= 0; i--)
			{
				reverseNumber[i] = number % 10;
				number /= 10;
				Console.Write(reverseNumber[i]);
			}
		}

		public static void ChangeEverySign(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] *= (-1);
				Console.Write($"{array[i]}\t");
			}
		}

		public static void GetSomeNumbers(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] > array[i - 1])
				{
					Console.Write($"{array[i]}\t");
				}
			}
		}

		public static void ArithmeticProgression(int start, int increment, int count)
		{
			int[] progression = new int[count];

			for (int i = 1; i < count; i++)
			{
				progression[0] = start;
				progression[i] = progression[i-1] + increment;
				Console.Write($"{progression[i]}\t");
			}
		}

		public static void GeometricProgression(int start, int increment, int count)
		{
			int[] progression = new int[count];

			for (int i = 1; i < count; i++)
			{
				progression[0] = start;
				progression[i] = progression[i - 1] * increment;
				Console.Write($"{progression[i]}\t");
			}
		}

	}
}
