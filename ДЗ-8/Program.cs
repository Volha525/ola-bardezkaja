using System;

namespace ClassString
{
	class Program
	{
		static void Main(string[] args)
		{
			String s1 = new String(new char[] { 'o', 'c', 'h', 'e', 'n', 's', 'l', 'o', 'z', 'h', 'n', 'o' });
			String s2 = new String(189994);

			Console.WriteLine($"{s1} contains slozhno {s1.Contains(new char[] { 's', 'l', 'o', 'z', 'h', 'n', 'o' })}");
			Console.WriteLine($"{s2} index of 9 {s2.IndexOf('9')}");
			Console.WriteLine($"{s1} + {s2} = {s1 + s2}");

			Console.ReadKey();
		}
	}
}