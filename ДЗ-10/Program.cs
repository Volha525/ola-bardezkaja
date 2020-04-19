using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Wolf wolf1 = new Wolf(1);
			wolf1.Eat();
			wolf1.Move();

			Console.WriteLine($"К волку добавился еще один волк и стало их {wolf1++}");
			Console.WriteLine($"В стаде случился прирост на 200%  и cтало их {wolf1 * 2}");

			Cat cat1 = new Cat();
			Cat cat2 = new Cat();
			cat1.Eat();
			cat2.Move();
			List<Cat> cats = new List<Cat> { cat1, cat2 };
			List<Cat> cat = cats - cat2;

			Console.Read();


		}
	}
}
