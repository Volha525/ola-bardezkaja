using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello
{
	class Program
	{
		static void Main(string[] args)
		{
			UserManager userManager = new UserManager();

			User olya = userManager.AddNewUser("Оля", "Бардецкая");
			User ruslan = userManager.AddNewUser("Руслан", "Соболь");
			User ivan = userManager.AddNewUser("Иван", "Черкас");

			Console.WriteLine("\n****************************\n");

			DeskManager deskManager = new DeskManager();

			Desk desk1 = deskManager.AddNewDesk("ДЗ№1", new DateTime(2020, 03, 15));
			Desk desk2 = deskManager.AddNewDesk("ДЗ№2", new DateTime(2020, 05, 25));

			Console.WriteLine("\n****************************\n");

			Card card1 = desk1.AddNewCard("github.com", "Выполненное ДЗ", olya);
			Card card2 = desk1.AddNewCard("github.com", "Выполненное ДЗ с некоторыми вопросами", ruslan);
			Card card3 = desk2.AddNewCard("github.com", "Выполненное ДЗ+ дополнительные", ivan);

			Console.WriteLine("\n****************************\n");

			card1.EditCardStatus(StatusTypes.OnStudent);

			Console.WriteLine("\n****************************\n");

			card1.EditCardUser(ruslan);

			Console.WriteLine("\n****************************\n");

			Console.WriteLine($"Все карточки статуса: {StatusTypes.OnStudent} ");
			PrintCards(desk1.GetCardsWithStatus(StatusTypes.OnStudent));
			Console.WriteLine($"Все карточки студента {ruslan} : ");
			 PrintCards(desk2.GetUserCards(ruslan));
			Console.WriteLine("\n****************************\n");

			Console.WriteLine("\n****************************\n");

			deskManager.ShowAllDesks();

			if(card1.IsCardInTime())
			{
				Console.WriteLine($"Карточка  {card1} выполнена вовремя");
			}
			else
				Console.WriteLine($"Карточка  {card1} просрочена");

			Console.WriteLine("\n****************************\n");

			desk1.ShowBadStudents();
			desk2.ShowBadStudents();

			Console.WriteLine("\n****************************\n");

			PrintAllUserCards(deskManager, userManager);

			Console.ReadLine();
		}

		public static void PrintCards(List<Card> cards)
		{
			if (cards.Count == 0)
			{
				Console.WriteLine("Таких карточек нет");
			}
			else
			{
				for (int i = 0; i < cards.Count; i++)
				{
					Console.WriteLine(cards[i]);
				}
			}
		}

		public static void PrintAllUserCards(DeskManager deskManager, UserManager userManager)
		{
			foreach(User u in userManager.Users)
			{
				Console.WriteLine($"Все карточки пользователя {u} :");
				foreach(Desk d in deskManager.Desks)
				{
					Console.Write($"На доске {d.Name}");
					PrintCards(d.GetUserCards(u));
				}
			}
		}
	}
}