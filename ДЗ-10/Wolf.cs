using System;

namespace Inheritance
{
	public class Wolf : WildAnimal
	{
		public override bool HasFlock => true;
		public override string Name => "Wolf";

		public Wolf(int flockAmount)
		{
			FlockAmount = flockAmount;
		}

		public override void Eat()
		{
			Console.WriteLine("Волк хищник  и сам добывает себе еду");
		}

		public override void Move()
		{
			Console.WriteLine("Волк очень быстрый");
		}

		public static Wolf operator ++(Wolf wolf)
		{
			if (wolf.HasFlock)
			{
				wolf.FlockAmount++;
			}

			return wolf;
		}

		public static Wolf operator *(Wolf wolf, int percent)
		{
			if (wolf.HasFlock)
			{
				wolf.FlockAmount *= percent;
			}

			return wolf;
		}

		public override string ToString()
		{
			return $"{FlockAmount}";
		}
	}
}
