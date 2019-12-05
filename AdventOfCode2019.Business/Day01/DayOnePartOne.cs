using System.Collections.Generic;
using System.Linq;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day01
{
	public class DayOnePartOne
	{
		private readonly List<int> massValues;

		public DayOnePartOne(List<int> massValues) =>
			this.massValues = massValues;

		private static int CalculateFuel(int mass) =>
			(mass / 3) - 2;

		public int Solve() =>
			this.massValues
				.Select(o => CalculateFuel(o))
				.Sum(o => o);
	}
}
