namespace Inheritance
{
	public abstract class WildAnimal : Animal
	{
		public abstract bool HasFlock { get; }
		public int FlockAmount { get; set; }
	}
}
