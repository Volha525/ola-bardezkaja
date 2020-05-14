using System;
using System.Collections.Generic;

namespace Trello
{
	class DeskManager
	{
		private ILogger _logger;

		public List<Desk> Desks { get; private set; } = new List<Desk>();

		public DeskManager(ILogger logger)
		{
			_logger = logger;
		}

		public Desk AddNewDesk(string name, DateTime deadline)
		{
			Desk desk = new Desk(name, deadline, _logger);
			Desks.Add(desk);

			desk.CardAddedEvent += DeskCardAddedEventHandler;
			desk.CardDeletedEvent += DeskCardDeletedEventHandler;

			PrintAndLogMessage($"Создана новая доска с именем {desk.Name} и сроком выполения до {desk.Deadline}");
			return desk;
		}

		public void DeleteDesk(Desk desk)
		{
			desk.CardAddedEvent -= DeskCardAddedEventHandler;
			desk.CardDeletedEvent -= DeskCardDeletedEventHandler;

			Desks.Remove(desk);
		}

		public void ShowAllDesks()
		{
			Console.WriteLine("Все доски:");
			foreach (Desk desk in Desks)
			{
				Console.WriteLine($"{desk.Name}\n");
			}
		}
		private void DeskCardAddedEventHandler(Desk desk,Card card)
		{
			PrintAndLogMessage($"Карточка {card.Name} была создана на доске {desk.Name}");
		}

		private void DeskCardDeletedEventHandler(Desk desk, Card card)
		{
			PrintAndLogMessage($"Карточка {card.Name} была удалена с доски {desk.Name}");
		}

		private void PrintAndLogMessage(string message)
		{
			Console.WriteLine(message);
			_logger.Log(message);
		}
	}
}