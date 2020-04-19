using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Cat : Animal
	{
		public override string Name => "Cat";

		public override void Eat()
		{
			Console.WriteLine("Котов кормят хозяева");
		}

		public override void Move()
		{
			Console.WriteLine("Коты любят бегать и играться");
		}
		public static List<Cat> operator -(List<Cat> cats, Cat catToRemove)
		{
			cats.Remove(catToRemove);
			return cats;
		}
	}
}
