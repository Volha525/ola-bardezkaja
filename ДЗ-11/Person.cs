namespace Hierarchy
{
	public abstract class Person
	{
		public string Name { get; private set; }
		public string Surname { get; private set; }
		public Departments Department { get; private set; }

		public abstract void Work();

		protected void Initialise(string name, string surname, Departments department)
		{
			Name = name;
			Surname = surname;
			Department = department;
		}
	}
}
