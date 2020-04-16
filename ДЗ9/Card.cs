using System;

namespace Trello
{
	class Card
	{
		private Desk _parentDesk;

		public string Body { get; set; }
		public string Name { get; set; }
		public StatusTypes Status { get; private set; }
		public User User { get; private set; }
		public DateTime CreationTime { get; private set; }

		public Card(string body, string name, User user, Desk parentDesk)
		{
			Body = body;
			Name = name;
			Status = StatusTypes.ToDo;
			User = user;
			CreationTime = DateTime.Now;
			_parentDesk = parentDesk;
		}

		public void EditCardStatus(StatusTypes status)
		{
			StatusTypes prevStatus = Status;
			Status = status;

			Console.WriteLine($"Статус карточки {this.Name} был изменен c {prevStatus} на {Status}");
		}

		public void EditCardUser(User user)
		{
			User prevUser = User;
			User = user;

			Console.WriteLine($"Исполнитель карточки {this.Name} был изменен c {prevUser} на {User}");
		}

		public bool IsCardInTime()
		{
			return _parentDesk.Deadline >= this.CreationTime;
		}

		public override string ToString()
		{
			return $"{Name}";
		}

	}
}