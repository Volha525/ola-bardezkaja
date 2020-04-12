namespace ClassString
{
	class String
	{
		private char[] myString;

		public int Length
		{
			get
			{
				return myString.Length;
			}
		}

		public bool NotUsedAutoProperty { get; set; }

		public String()
		{
			myString = new char[0];
		}

		public String(int number)
		{
			if (number == 0)
			{
				myString = new char[1] { '0' };
				return;
			}

			int copyNumber = number;
			int counter = 0;

			while (copyNumber != 0)
			{
				copyNumber /= 10;
				counter++;
			}

			if (number > 0)
			{
				myString = new char[counter];
			}
			else
			{
				myString = new char[++counter];
				myString[0] = '-';
				number *= (-1);
			}

			for (int i = counter - 1; number != 0; i--)
			{
				myString[i] = (char)(48 + number % 10);
				number /= 10;
			}
		}

		public String(char[] array)
		{
			myString = new char[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				myString[i] = array[i];
			}
		}

		public override string ToString()
		{
			return new string(myString);
		}

		public int IndexOf(char ch)
		{
			for (int i = 0; i < myString.Length; i++)
			{
				if (myString[i] == ch)
				{
					return i;
				}
			}

			return -1;
		}

		public bool Contains(char[] array)
		{
			if (array == null || array.Length == 0)
			{
				return false;
			}

			for (int i = 0; i < myString.Length; i++)
			{
				if (myString[i] == array[0] && (i + array.Length - 1) <= myString.Length)
				{
					bool isSimilar = true;

					for (int j = 1; j < array.Length; j++)
					{
						if (myString[i + j] != array[j])
						{
							isSimilar = false;
							break;
						}
					}

					if (isSimilar)
					{
						return true;
					}
				}
			}

			return false;
		}

		public char this[int index]
		{
			get
			{
				return myString[index];
			}
		}

		public static String operator +(String s1, String s2)
		{
			char[] array = new char[s1.Length + s2.Length];

			int i = 0;
			for (; i < s1.Length; i++)
			{
				array[i] = s1[i];
			}
			for (int j = 0; j < s2.Length; j++)
			{
				array[i + j] = s2[j];
			}

			return new String(array);
		}
	}
}