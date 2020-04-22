using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
	class Program
	{
		static void Main(string[] args)
		{
			HeadOfDepartment evgenij = new HeadOfDepartment("Evgenij", "Bulka", Departments.Biological);
			Teacher tomas = new Teacher("Tomas", "Anderson", Departments.Historical, Subjects.History);
			Group group1 = new Group("PPS");
			Student ola = new Student("Olja", "Bardezkaja", Departments.Biological, group1);
			Student vitya = new Student("Vitya", "Pushkin", Departments.Biological, group1);
			Student ivan = new Student("ivan", "Kokov", Departments.Biological, group1);

			group1.Students.Add(ola);
			group1.Students.Add(vitya);
			group1.Students.Add(ivan);

			ola.Work();
			tomas.Work();
			evgenij.Work();

			tomas.AddGradeToStudent(10, ola);
			tomas.AddGradeToStudent(10, vitya);
			tomas.AddGradeToStudent(9, ivan);

			Console.WriteLine(ola.Equals(vitya));
			Console.WriteLine(ola.Equals(ivan));

			Console.ReadLine();
		}
	}
}
