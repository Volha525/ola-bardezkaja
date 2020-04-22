using System;
using System.Collections.Generic;

namespace Hierarchy
{
	public class HeadOfDepartment : Person
	{
		public static List<Departments> AvailableDepartments { get; private set; }

		static HeadOfDepartment()
		{
			AvailableDepartments = new List<Departments>
			{
				Departments.Biological,
				Departments.Chemical,
				Departments.Economic,
				Departments.Historical,
				Departments.Journalistic
			};
		}

		public HeadOfDepartment(string name, string surname, Departments department)
		{
			Initialise(name, surname, department);

			AvailableDepartments.Remove(department);
		}

		public override void Work()
		{
			Console.WriteLine($"{this.Name} {this.Surname} is Had of {this.Department} Department");
		}
	}
}
