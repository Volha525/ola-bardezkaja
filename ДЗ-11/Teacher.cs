using System;

namespace Hierarchy
{
	public class Teacher : Person
	{
		public Subjects Subject { get; set; }

		public Teacher(string name, string surname, Departments department, Subjects subject)
		{
			Initialise(name, surname, department);

			Subject = subject;
		}

		public override void Work()
		{
			Console.WriteLine($"{this.Name} {this.Surname} is teaching {this.Subject} on {this.Department} Department");
		}

		public void AddGradeToStudent(int grade, Student student)
		{
			student.Grades.Add(grade);
		}
	}
}
