using System.Linq;
using System.Text.RegularExpressions;

using com.nerdlyhaxor.AdventOfCode.Util;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day04
{
	public static class PasswordValidator
	{
		public static bool IsValidPassword(string password) =>
			IsCorrectLength(password)
				&& NeverDecreases(password)
				&& ContainsDuplicates(password);

		public static bool IsCorrectLength(string password) =>
			string.IsNullOrEmpty(password) ? false : password.Length == 6;

		public static bool ContainsDuplicates(string password) =>
			Regex.Match(password, "(11|22|33|44|55|66|77|88|99)")
				.Success;

		public static bool NeverDecreases(string password)
		{
			var valueMatches = Regex.Match(password, @"(\d){6}");
			var higestValue = 0;

			if (!valueMatches.Success)
				return false;

			var values = valueMatches
					.Groups[1]
					.Captures
					.Select(o => o.Value.ToInt())
					.ToList();

			foreach (var value in values)
			{
				if (value >= higestValue)
					higestValue = value;
				else
					return false;
			}

			return true;
		}
	}
}
