using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.nerdlyhaxor.AdventOfCode.Logic
{
	public class DayOnePartTwo
	{
		private List<int> massValues;

		public DayOnePartTwo(List<int> massValues) =>
			this.massValues = massValues;

		private int calculateFuel(int mass) =>
			(mass / 3) - 2;

		public int Solve() =>
			massValues
				.Select(o => this.calculateFuel(o))
				.Sum(o => o);
	}
}
