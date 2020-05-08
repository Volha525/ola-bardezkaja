using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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

			Card card1 = desk1.AddCard("github.com", "Выполненное ДЗ", olya);
			Card card2 = desk1.AddCard("github.com", "Выполненное ДЗ с некоторыми вопросами", ruslan);
			Card card3 = desk2.AddCard("github.com", "Выполненное ДЗ+ дополнительные", ivan);

			Console.WriteLine();

			Console.WriteLine("\n****************************\n");

			card1.Status = StatusTypes.OnStudent;

			Console.WriteLine("\n****************************\n");

			card1.EditCardUser(ruslan);

			Console.WriteLine("\n****************************\n");

			Console.WriteLine("\n**************DemonstrateExceptions**************\n");

			DemonstrateExceptions(deskManager);

			Console.WriteLine("\n**************SerializeDeskManager**************\n");

			string serializedManager = SerializeDeskManager(deskManager);
			Console.WriteLine(serializedManager);
			
			File.WriteAllText("serializedCard.json", serializedManager);

			Console.WriteLine("\n**************DeserializeDeskManager**************\n");

			serializedManager = serializedManager.Replace("git", "porn");
			DeskManager deserializedManager1 = DeserializeDeskManager(serializedManager);
			Console.WriteLine(deserializedManager1 != null);

			serializedManager = serializedManager.Replace("{", "(");
			DeskManager deserializedManager2 = DeserializeDeskManager(serializedManager);
			
		        File.ReadAllText("deserializedCard.json");
			
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
			foreach (User u in userManager.Users)
			{
				Console.WriteLine($"Все карточки пользователя {u} :");
				foreach (Desk d in deskManager.Desks)
				{
					Console.Write($"На доске {d.Name}");
					PrintCards(d.GetUserCards(u));
				}
			}
		}

		private static void DemonstrateExceptions(DeskManager deskManager)
		{
			try
			{
				deskManager.DeleteDesk(null);
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Проверьте правильность указания доски");
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
		}

		private static string SerializeDeskManager(DeskManager deskManager)
		{
			return JsonConvert.SerializeObject(deskManager, Formatting.Indented);
		}

		private static DeskManager DeserializeDeskManager(string serializedManager)
		{
			DeskManager deskManager = null;
			try
			{
				deskManager = JsonConvert.DeserializeObject<DeskManager>(serializedManager);
			}
			catch (Exception exc)
			{
				Console.WriteLine("Неправильный формат" + exc.Message);
			}

			return deskManager;
		}
	}
}
