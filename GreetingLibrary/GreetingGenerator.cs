using System;

namespace GreetingLibrary
{
	public class GreetingGenerator
	{
		public string GenerateGreeting(string prefix, string lastName, int hourOfDay)
		{
			string output = hourOfDay < 6
				? $"Good night {prefix} {lastName}"
				: hourOfDay < 12
					? $"Good morning {prefix} {lastName}"
					: hourOfDay < 18 ? $"Good afternoon {prefix} {lastName}" : $"Good evening {prefix} {lastName}";

			return output;
		}
	}
}
