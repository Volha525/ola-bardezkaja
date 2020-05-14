using System;
using System.Collections.Generic;

namespace Trello
{
	class Desk
	{
		private ILogger _logger;

		public List<Card> Cards { get; private set; } = new List<Card>();

		public string Name { get; set; }
		public DateTime Deadline { get; private set; }

		public delegate void CardCreationDelegate(Desk desk, Card card);

		public event CardCreationDelegate CardAddedEvent;
		public event CardCreationDelegate CardDeletedEvent;

		public Desk(string name, DateTime deadline, ILogger logger)
		{
			Name = name;
			Deadline = deadline;
			_logger = logger;
		}

		public Card AddCard(string body, string name, User user)
		{
			Card card = new Card(body, name, user, this);
			Cards.Add(card);

			card.StatusChangedEvent += CardStatusChangedEventHandler;
			card.UserChangedEvent += CardUserChangedEventHandler;

			CardAddedEvent?.Invoke(this, card);

			return card;
		}

		public void DeleteCard(Card card)
		{
			card.StatusChangedEvent -= CardStatusChangedEventHandler;
			card.UserChangedEvent -= CardUserChangedEventHandler;

			Cards.Remove(card);

			CardDeletedEvent?.Invoke(this, card);
		}

		public List<Card> GetCardsWithStatus(StatusTypes status)
		{
			List<Card> thisStatus = new List<Card>();

			foreach (Card card in Cards)
			{
				if (card.Status == status)
				{
					thisStatus.Add(card);
				}
			}

			return thisStatus;
		}

		public List<Card> GetUserCards(User user)
		{
			List<Card> thisUser = new List<Card>();

			foreach (Card card in Cards)
			{
				if (card.User == user)
				{
					thisUser.Add(card);
				}
			}

			return thisUser;
		}

		public void ShowBadStudents()
		{
			foreach (Card card in Cards)
			{
				if (card.IsCardInTime() == false)
				{
					PrintAndLogMessage($"Просроченная карточка {card.Name} студента {card.User}");
				}
			}
		}

		private void CardStatusChangedEventHandler(Card card)
		{
			PrintAndLogMessage($"Статус карточки {card.Name} был изменен на {card.Status}");
		}

		private void CardUserChangedEventHandler(Card card)
		{
			PrintAndLogMessage($"Пользователь карточки {card.Name} был изменен на {card.User}");
		}

		private void PrintAndLogMessage(string message)
		{
			Console.WriteLine(message);
			_logger.Log(message);
		}
	}
}