using System;
using System.Collections.Generic;

namespace Trello
{
	class DeskManager
	{
		public List<Desk> Desks { get; private set; } = new List<Desk>();

		public Desk AddNewDesk(string name, DateTime deadline)
		{
			Desk desk = new Desk(name, deadline);
			Desks.Add(desk);

			Console.WriteLine($"Создана новая доска с именем {desk.Name} и сроком выполения до {desk.Deadline}");
			return desk;
		}

		public void DeleteDesk(Desk desk)
		{
			Desks.Remove(desk);
		}

		public void ShowAllDesks()
		{
			Console.WriteLine("Все доски:");
			foreach(Desk desk in Desks)
			{
				Console.WriteLine($"{desk.Name}\n");
			}
		}
	}
}