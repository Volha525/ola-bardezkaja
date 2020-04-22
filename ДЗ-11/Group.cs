using System.Collections.Generic;

namespace Hierarchy
{
	public class Group
	{
		public string Name { get; set; }
		public List<Student> Students { get; set; } = new List<Student>();

		public Group(string name)
		{
			Name = name;
		}

		public Student GetBestStudent()
		{
			if(Students.Count == 0)
			{
				return null;
			}

			Student bestStudent = Students[0];
			for (int i = 1; i < Students.Count; i++)
			{
				if (Students[i].GetAverageGrade() > bestStudent.GetAverageGrade())
				{
					bestStudent = Students[i];
				}
			}

			return bestStudent;
		}

		public Student GetWorstStudent()
		{
			if (Students.Count == 0)
			{
				return null;
			}

			Student worstStudent = Students[0];
			for (int i = 1; i < Students.Count; i++)
			{
				if (Students[i].GetAverageGrade() < worstStudent.GetAverageGrade())
				{
					worstStudent = Students[i];
				}
			}

			return worstStudent;
		}


		public override string ToString()
		{
			return Name;
		}
	}
}
