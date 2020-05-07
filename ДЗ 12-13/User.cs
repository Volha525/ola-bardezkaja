using Newtonsoft.Json;

namespace Trello
{
	public class User
	{
		public string Name { get; private set; }
		public string LastName { get; private set; }

		public User(string name, string lastName)
		{
			Name = name;
			LastName = lastName;
		}

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}