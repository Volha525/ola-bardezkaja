using System;
using System.Collections.Generic;

namespace Hierarchy
{
	public class Student : Person
	{
		public List<int> Grades { get; set; } = new List<int>();
		public Group Group { get; private set;}

		public Student(string name, string surname, Departments department, Group group)
		{
			Initialise(name, surname, department);

			Group = group;
		}

		public override void Work()
		{
			Console.WriteLine($" {this.Name} {this.Surname} is studying in {this.Group} on {this.Department} Department");
		}

		public float GetAverageGrade()
		{
			int total = 0;

			foreach (int grade in Grades)
			{
				total += grade;
			}

			return (float)total / Grades.Count;
		}

		public override string ToString()
		{
			return $"{Name} {Surname}";
		}

		public override bool Equals(object obj)
		{
			Student otherStudent = (Student)obj;
			return this.GetAverageGrade() == otherStudent.GetAverageGrade();
		}
	}
}
