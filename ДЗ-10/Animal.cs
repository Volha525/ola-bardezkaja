using System.Collections.Generic;

namespace Inheritance
{
	public abstract class Animal
	{
		public abstract string Name { get; }
		public int Weight { get; set; }

		public abstract void Eat();
		public abstract void Move();
	}
}
