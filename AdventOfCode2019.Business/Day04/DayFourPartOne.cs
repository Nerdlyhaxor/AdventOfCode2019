using System.Globalization;

using com.nerdlyhaxor.AdventOfCode.Util;
using com.nerdlyhaxor.AdventOfCode.Logic.Base;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day04
{
	public class DayFourPartOne : AdventOfCodeSolver
	{
		public override string Solve(string fileName)
		{
			int numberOfValidPasswords = 0;

			ParseFile(fileName, out int min, out int max);

			for(var currentPassword = min; currentPassword <= max; currentPassword++)
			{
				numberOfValidPasswords += PasswordValidator.IsValidPassword(currentPassword.ToString(CultureInfo.InvariantCulture)) ? 1 : 0;
			}

			return numberOfValidPasswords.ToString(CultureInfo.InvariantCulture);
		}

		public static void ParseFile(string fileName, out int min, out int max)
		{
			var lines = FileHelper.GetFileContent(fileName);
			var values = lines[0].Split(',');

			min = values[0].ToInt();
			max = values[1].ToInt();
		}
	}
}
