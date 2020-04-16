using System;
using System.Collections.Generic;

namespace Trello
{
	class Desk
	{
		public List<Card> Cards { get; private set; } = new List<Card>();

		public string Name { get; set; }
		public DateTime Deadline { get; private set; }

		public Desk(string name, DateTime deadline)
		{
			Name = name;
			Deadline = deadline;
		}

		public Card AddNewCard(string body, string name, User user)
		{
			Card card = new Card(body, name, user, this);
			Cards.Add(card);

			Console.WriteLine($"Создана новая карточка {card.Name} пользователем {card.User} на доске {this.Name}");
			return card;
		}

		public void DeleteCard(Card card)
		{
			Cards.Remove(card);
		}

		public List<Card> GetCardsWithStatus(StatusTypes status)
		{
			List<Card> thisStatus = new List<Card>();

			foreach(Card card in Cards)
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
					Console.WriteLine($"Просроченная карточка {card.Name} студента {card.User}");
				}
			}
		}
	}
}