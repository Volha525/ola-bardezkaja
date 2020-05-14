using System;
using System.Collections.Generic;

namespace Trello
{
	class UserManager
	{
		private ILogger _logger;

		public List<User> Users { get; private set; } = new List<User>();

		public UserManager(ILogger logger)
		{
			_logger = logger;
		}

		public User AddNewUser(string name, string lastName)
		{
			User user = new User(name, lastName);

			Users.Add(user);

			PrintAndLogMessage($"Создан новый пользователь {user.Name} {user.LastName}");
			return user;
		}

		public void DeleteUser(User user)
		{
			Users.Remove(user);
		}

		private void PrintAndLogMessage(string message)
		{
			Console.WriteLine(message);
			_logger.Log(message);
		}
	}
}
