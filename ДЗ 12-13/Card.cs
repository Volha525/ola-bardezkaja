using System;
using Newtonsoft.Json;

namespace Trello
{
	class Card
	{
		private Desk _parentDesk;
		private StatusTypes _status;

		public string Body { get; set; }
		public string Name { get; set; }

		public StatusTypes Status
		{
			get { return _status; }
			set
			{
				if (_status == value)
				{
					return;
				}

				_status = value;
				StatusChangedEvent?.Invoke(this);
			}
		}

		public User User { get; private set; }
		public DateTime CreationTime { get; private set; }

		public delegate void StatusChangedDelegate(Card card);
		public delegate void UserChangedDelegate(Card card);

		public event StatusChangedDelegate StatusChangedEvent;
		public event UserChangedDelegate UserChangedEvent;

		public Card(string body, string name, User user, Desk parentDesk)
		{
			Body = body;
			Name = name;
			Status = StatusTypes.ToDo;
			User = user;
			CreationTime = DateTime.Now;
			_parentDesk = parentDesk;
		}

		public void EditCardUser(User user)
		{
			User prevUser = User;
			User = user;

			UserChangedEvent?.Invoke(this);
		}

		public bool IsCardInTime()
		{
			return _parentDesk.Deadline >= this.CreationTime;
		}

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}