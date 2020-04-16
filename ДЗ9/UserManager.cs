using System;
using System.Collections.Generic;

namespace Trello
{
	class UserManager
	{
		public List<User> Users { get; private set; } = new List<User>();

		public User AddNewUser(string name, string lastName)
		{
			User user = new User(name, lastName);

			Users.Add(user);

			Console.WriteLine($"Создан новый пользователь {user.Name} {user.LastName}");
			return user;
		}

		public void DeleteUser(User user)
		{
			Users.Remove(user);
		}
	}
}
