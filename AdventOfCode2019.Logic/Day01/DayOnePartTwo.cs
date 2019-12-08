using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic.Day01
{
	public class DayOnePartTwo
	{
		private readonly List<int> massValues;

		public DayOnePartTwo(List<int> massValues) =>
			this.massValues = massValues;

		private static int CalculateFuel(int mass) =>
			(mass / 3) - 2;

		public int Solve() =>
			this.massValues
				.Select(o => CalculateFuel(o))
				.Sum(o => o);
	}
}
